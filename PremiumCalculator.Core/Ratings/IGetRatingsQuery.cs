using PremiumCalculator.Domain.Ratings;

namespace PremiumCalculator.Core.Ratings
{
    /// <summary>
    /// interface to provide ratings data
    /// </summary>
    public interface IGetRatingsQuery
    { 
        /// <summary>
        /// fetches the list of ratings
        /// </summary>
        /// <returns>Ratings</returns>
        IEnumerable<Rating> Execute();

        /// <summary>
        /// gets the rating factor associated with the occupation id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        double GetRatingFacor(int occupationId);
    }
}
