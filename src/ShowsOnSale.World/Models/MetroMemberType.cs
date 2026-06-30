namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// Describes the kind of geographical unit a <see cref="MetroMember"/> represents.
    /// A metro area can be composed of a flexible mix of these.
    /// </summary>
    public enum MetroMemberType
    {
        /// <summary>A single city or town (resolvable to a <see cref="City"/>).</summary>
        City,

        /// <summary>
        /// A county / borough / district. Counties are not present in the underlying
        /// countries-states-cities dataset, so county members are described by name only
        /// (no <see cref="MetroMember.CityId"/>).
        /// </summary>
        County,

        /// <summary>An entire state / region (resolvable to a <see cref="State"/>).</summary>
        State
    }
}
