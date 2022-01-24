using PremiumCalculator.Domain.Occupations;

namespace PremiumCalculator.Core.Occupations
{
    /// <summary>
    /// public interface to provide occupations 
    /// </summary>
    public interface IOccupationQuery
    {
        /// <summary>
        /// fetches the list of occupations 
        /// </summary>
        /// <returns>List of Occupations</returns>
        IEnumerable<Occupation> Execute();
    }
}
