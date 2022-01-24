namespace PremiumCalculator.Core.Customers
{
    /// <summary>
    /// core interface to provide customer's monthly premium
    /// </summary>
    public interface IGetCustomerMonthlyPremium
    {
        /// <summary>
        /// calculates and returns monthly premium based on customer's input data
        /// </summary>
        /// <param name="occupationId"></param>
        /// <param name="age"></param>
        /// <param name="sumInsured"></param>
        /// <returns>monthly premium</returns>
        double Execute(int occupationId, int age, double sumInsured);
    }
}
