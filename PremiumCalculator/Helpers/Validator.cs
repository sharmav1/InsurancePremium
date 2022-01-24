namespace PremiumCalculator.Api.Helpers
{
    public class Validator
    {
        /// <summary>
        /// Validate all incoming request data. Assuming age to be between 0 to 100
        /// </summary>
        /// <param name="occupationId"></param>
        /// <param name="age"></param>
        /// <param name="sumInsured"></param>
        /// <returns></returns>
        public static bool ValidateInput(int occupationId, int age, double sumInsured)
        {
            bool result = true;

            if (occupationId <= 0 || age <= 0 || sumInsured <= 0) result = false;

            return result;
        }
    }
}
