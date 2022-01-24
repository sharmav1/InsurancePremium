namespace PremiumCalculator.Api.Helpers
{
    public class Validator
    {
        /// <summary>
        /// Validate all incoming request data. Assuming age not be less than 18
        /// </summary>
        /// <param name="occupationId"></param>
        /// <param name="age"></param>
        /// <param name="sumInsured"></param>
        /// <returns></returns>
        public static bool ValidateInput(int occupationId, int age, double sumInsured)
        {
            bool result = true;

            if (occupationId <= 0 || age <= 18 || sumInsured <= 0) result = false;

            return result;
        }
    }
}
