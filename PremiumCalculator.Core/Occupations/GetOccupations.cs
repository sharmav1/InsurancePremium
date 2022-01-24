using PremiumCalculator.Domain.Occupations;

namespace PremiumCalculator.Core.Occupations
{
    /// <summary>
    /// provides implementation for <see cref="IOccupationQuery"/>
    /// </summary>
    public class GetOccupations : IOccupationQuery
    {
        public IEnumerable<Occupation> Execute()
        {
            return new List<Occupation>
            {
                new Occupation { Id = 1001, Description = "Cleaner", Rating = 1201 },
                new Occupation { Id = 1002, Description = "Doctor", Rating = 1203 },
                new Occupation { Id = 1003, Description = "Author", Rating = 1204 },
                new Occupation { Id = 1004, Description = "Farmer", Rating = 1202 },
                new Occupation { Id = 1005, Description = "Mechanic", Rating = 1202 },
                new Occupation { Id = 1006, Description = "Florist", Rating = 1201 },
            };
        }

    }
}
