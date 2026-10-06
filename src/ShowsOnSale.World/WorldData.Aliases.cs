using System.Linq;

namespace ShowsOnSale.World
{
    public static partial class WorldData
    {
        /// <summary>
        /// Initializes aliases for all countries after the main data is loaded.
        /// This is called once when the WorldData type is first used.
        /// </summary>
        private static void InitializeAliases()
        {
            foreach (var country in All)
            {
                if (Data.CountryAliases.Aliases.TryGetValue(country.Iso2, out var aliases))
                {
                    country.Aliases = aliases;
                }
            }
        }

        // Trigger alias initialization after All is fully constructed
        private static readonly object AliasInitLock = new object();
        private static bool AliasesInitialized { get; set; }

        /// <summary>
        /// Ensure aliases are populated on first access to All.
        /// </summary>
        static WorldData()
        {
            lock (AliasInitLock)
            {
                if (!AliasesInitialized)
                {
                    InitializeAliases();
                    AliasesInitialized = true;
                }
            }
        }
    }
}
