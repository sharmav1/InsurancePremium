using PremiumCalculator.Core.Ratings;

namespace PremiumCalculator.Core.Customers
{
    /// <summary>
    /// provides implementation for <see cref="IGetCustomerMonthlyPremium"/>
    /// </summary>
    public class GetCustomerMonthlyPremium : IGetCustomerMonthlyPremium
    {
        private readonly IGetRatingsQuery _getRatingsQuery;
        public GetCustomerMonthlyPremium(IGetRatingsQuery getRatingsQuery)
        {
            _getRatingsQuery = getRatingsQuery;
        }

        public double Execute(int occupationId, int age, double sumInsured)
        {
            try
            {
                // get rating factor for customer's occupation
                var factor = GetRatingFactor(occupationId);

                // calculate premium
                var result = CalculatePremium(age, sumInsured, factor);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private double CalculatePremium(int customerAge, double sumInsured, double ratingFactor)
        {
            return (sumInsured * ratingFactor * customerAge) / (1000 * 12);
        }

        private double GetRatingFactor(int occupationId)
        {
            return _getRatingsQuery.GetRatingFacor(occupationId);
        }
    }
}
