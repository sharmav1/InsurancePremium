using PremiumCalculator.Core.Occupations;
using System.Linq;
using Xunit;

namespace PremiumCalculator.Api.Tests.Occupations
{
    public class OccupationTests
    {
        [Fact]
        public void WhenGetOccupations_Executes_Returns_Occupation_Data_Correctly()
        {
            //Arrange
            IOccupationQuery _query = new GetOccupations();

            //Act
            var result = _query.Execute().ToList();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(6, result.Count);
        }
    }
}