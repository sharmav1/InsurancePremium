using PremiumCalculator.Core.Occupations;
using PremiumCalculator.Domain.Ratings;

namespace PremiumCalculator.Core.Ratings
{
    /// <summary>
    /// provides implementation for <see cref="IGetRatingsQuery"/>
    /// </summary>
    public class GetRatings : IGetRatingsQuery
    {
        private readonly IOccupationQuery _occupationQuery;
        public GetRatings(IOccupationQuery occupationQuery)
        {
            _occupationQuery = occupationQuery;
        }
        public IEnumerable<Rating> Execute()
        {
            return new List<Rating>
            {
                new Rating { Id = 1201, Description = "Light Manual", Factor = 1.50 },
                new Rating { Id = 1202, Description = "Heavy Manual", Factor = 1.75 },
                new Rating { Id = 1203, Description = "Professional", Factor = 1.0 },
                new Rating { Id = 1204, Description = "White Collar", Factor = 1.25 }
            };
        }

        public double GetRatingFacor(int occupationId)
        {
            double result = 0;
            try
            {
                var occupation = _occupationQuery.Execute().SingleOrDefault(x => x.Id == occupationId);
                result = Execute().SingleOrDefault(x => x.Id == occupation.Rating).Factor;
            }
            catch (NullReferenceException ex)
            {
                // log exception
                throw;
            }
            catch (InvalidOperationException ex)
            {
                // log exception
                throw;
            }
            catch (Exception ex)
            {
                // log exception
                throw;
            }
            return result;
        }

    }
}
