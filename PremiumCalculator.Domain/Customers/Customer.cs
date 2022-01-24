namespace PremiumCalculator.Domain.Customers
{
    /// <summary>
    /// Custmer Entity
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer unique Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer's Name
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// customer's age, default set to 18
        /// Business Assumption: insurance can't be done for customer less than 18
        /// </summary>
        public short Age { get; set; } = 18;

        /// <summary>
        /// Customer's Data of Birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The amount of sum insured by customer
        /// </summary>
        public double SumInsured { get; set; }

        /// <summary>
        /// Customer's occupation id
        /// </summary>
        public int OccupationId { get; set; }
    }
}