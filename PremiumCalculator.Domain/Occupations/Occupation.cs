namespace PremiumCalculator.Domain.Occupations
{
    /// <summary>
    /// Describes customer's occupation
    /// </summary>
    public class Occupation
    {
        /// <summary>
        /// unique identifier for each occupation
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// describes the occupation
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// rating associated with each occupation
        /// </summary>
        public int Rating { get; set; } = 1201;
    }
}
