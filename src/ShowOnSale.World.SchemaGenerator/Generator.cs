// Usage: dotnet run -- <input.json> <output.schema.json>

using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace ShowOnSale.World.SchemaGenerator;

public class Program
{
    public static int Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.Error.WriteLine("Usage: dotnet run -- <input.json> <output.schema.json>");
            return 1;
        }

        string inputPath = args[0];
        string outputPath = args[1];

        try
        {
            // Read the input JSON
            string json = File.ReadAllText(inputPath);
            JArray data = JArray.Parse(json);

            if (data.Count == 0)
            {
                throw new Exception("Input JSON array is empty");
            }

            // Generate schema by analyzing the first item
            var firstItem = data[0] as JObject;
            if (firstItem == null)
            {
                throw new Exception("Expected array of objects");
            }

            var schema = new JSchema
            {
                Type = JSchemaType.Array,
                Items = { GenerateObjectSchema(firstItem) }
            };

            // Save schema to file with proper formatting
            using (var writer = new StreamWriter(outputPath))
            using (var jsonWriter = new JsonTextWriter(writer) { Formatting = Formatting.Indented })
            {
                schema.WriteTo(jsonWriter);
            }

            Console.WriteLine($"Schema written to: {outputPath}");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            return 1;
        }
    }

    private static JSchema GenerateObjectSchema(JObject obj)
    {
        var schema = new JSchema { Type = JSchemaType.Object };

        foreach (var prop in obj.Properties())
        {
            var propertySchema = GeneratePropertySchema(prop.Value);
            schema.Properties.Add(prop.Name, propertySchema);
            schema.Required.Add(prop.Name);
        }

        return schema;
    }

    private static JSchema GeneratePropertySchema(JToken value)
    {
        switch (value.Type)
        {
            case JTokenType.Object:
                return GenerateObjectSchema((JObject)value);
            case JTokenType.Array:
                var arraySchema = new JSchema { Type = JSchemaType.Array };
                var items = (JArray)value;
                if (items.Count > 0)
                {
                    arraySchema.Items.Add(GeneratePropertySchema(items[0]));
                }
                return arraySchema;
            case JTokenType.Integer:
                return new JSchema { Type = JSchemaType.Integer };
            case JTokenType.Float:
                return new JSchema { Type = JSchemaType.Number };
            case JTokenType.String:
                return new JSchema { Type = JSchemaType.String };
            case JTokenType.Boolean:
                return new JSchema { Type = JSchemaType.Boolean };
            case JTokenType.Null:
                return new JSchema { Type = JSchemaType.Null };
            default:
                throw new Exception($"Unsupported type: {value.Type}");
        }
    }
}
