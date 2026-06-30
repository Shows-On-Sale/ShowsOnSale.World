using System.Globalization;

namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// Internal helpers for parsing the dataset's string latitude/longitude values into numbers.
    /// </summary>
    /// <remarks>
    /// Coordinates are stored as decimal-degree strings (e.g. <c>"40.71427000"</c>, <c>"-74.00597000"</c>)
    /// using a <c>.</c> decimal separator, to match the upstream countries-states-cities dataset.
    /// Models expose <c>*Value</c> accessors that parse these with the invariant culture.
    /// </remarks>
    internal static class GeoCoordinate
    {
        /// <summary>
        /// Parses a decimal-degree coordinate string with the invariant culture.
        /// </summary>
        /// <param name="value">The coordinate string (decimal degrees).</param>
        /// <returns>The parsed value, or null if <paramref name="value"/> is null/blank or unparseable.</returns>
        public static double? Parse(string? value)
        {
            return double.TryParse(value, NumberStyles.Float | NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture, out var result)
                ? result
                : null;
        }
    }
}
