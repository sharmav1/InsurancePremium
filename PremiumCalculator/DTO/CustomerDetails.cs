namespace PremiumCalculator.Api.DTO
{
    public class CustomerDetails
    {
        public string Name { get; set; } = "";
        public short Age { get; set; } = 1;
        public DateTime DateOfBirth { get; set; }
        public double SumInsured { get; set; }
        public int OccupationId { get; set; }
    }
}
