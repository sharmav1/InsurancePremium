namespace PremiumCalculator.Domain.Ratings
{
    /// <summary>
    /// Ratings assigned to <see cref="Occupations"/>
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Unique identifier for each rating
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Describes a rating
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// Factor associated with each rating
        /// </summary>
        public double Factor { get; set; } = 0;
        
    }

}
