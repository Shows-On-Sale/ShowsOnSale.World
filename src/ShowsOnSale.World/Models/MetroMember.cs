namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// A single constituent of a <see cref="MetroArea"/> — a city, county, or state.
    /// </summary>
    /// <remarks>
    /// Members are addressed by a composite key rather than a single id, because the
    /// underlying dataset has two important quirks:
    /// <list type="bullet">
    ///   <item><description><c>City.Id</c> is only unique <i>within a state</i>, not globally
    ///   (e.g. "Newark" exists with id 322 in NJ and id 632... in several states).</description></item>
    ///   <item><description><c>State.StateCode</c> is empty for some countries (notably the US),
    ///   so <c>State.Id</c> is used as the foreign key. <c>State.Id</c> is unique only
    ///   <i>within a country</i> (many countries reuse the same numeric id), so it must always be
    ///   resolved together with <see cref="CountryIso2"/>.</description></item>
    /// </list>
    /// Display names (<see cref="Name"/>, <see cref="StateName"/>) are denormalized so a member
    /// remains meaningful even if an upstream id shifts during data regeneration.
    /// </remarks>
    public class MetroMember
    {
        /// <summary>The kind of unit this member represents.</summary>
        public required MetroMemberType Type { get; init; }

        /// <summary>ISO2 code of the country this member belongs to (members can cross borders).</summary>
        public required string CountryIso2 { get; init; }

        /// <summary>
        /// Foreign key to <see cref="State.Id"/>, unique only within <see cref="CountryIso2"/>
        /// (resolve the two together). Null only when the member cannot be tied to a state in the dataset.
        /// </summary>
        public int? StateId { get; init; }

        /// <summary>Denormalized state / region name for display and robustness.</summary>
        public string? StateName { get; init; }

        /// <summary>
        /// Foreign key to <see cref="City.Id"/>, unique within the owning state. Set only for
        /// <see cref="MetroMemberType.City"/> members; null for county and state members.
        /// </summary>
        public int? CityId { get; init; }

        /// <summary>Display name of the member (the city, county, or state name).</summary>
        public required string Name { get; init; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} ({Type})";
        }
    }
}
