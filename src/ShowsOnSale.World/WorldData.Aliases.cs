namespace ShowsOnSale.World
{
    public static partial class WorldData
    {
        /// <summary>
        /// Populates <see cref="Models.Country.Aliases"/> from the hand-maintained
        /// <see cref="Data.CountryAliases"/> table. The aliases live outside the generated
        /// country files so that regenerating the data does not drop them.
        /// </summary>
        static WorldData()
        {
            foreach (var country in All)
            {
                if (Data.CountryAliases.Aliases.TryGetValue(country.Iso2, out var aliases))
                {
                    country.Aliases = aliases;
                }
            }
        }
    }
}
