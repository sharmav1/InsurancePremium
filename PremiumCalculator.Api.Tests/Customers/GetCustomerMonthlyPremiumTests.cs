using Moq;
using PremiumCalculator.Core.Customers;
using PremiumCalculator.Core.Occupations;
using PremiumCalculator.Core.Ratings;
using PremiumCalculator.Domain.Ratings;
using System.Collections.Generic;
using Xunit;

namespace PremiumCalculator.Api.Tests.Customers
{
    public class GetCustomerMonthlyPremiumTests
    {
        Mock<IGetRatingsQuery> _ratingsQuery;
        
        public GetCustomerMonthlyPremiumTests()
        {
            _ratingsQuery = new Mock<IGetRatingsQuery>();
        }

        [Fact]
        public void When_GetCustomerMonthlyPremium_Executes_Successfully_Should_Return_Correct_Premium()
        {
            int occupationId = 1002;
            int age = 30;
            double sumInsured = 100000;

            // Arrange
            _ratingsQuery.Setup(x => x.GetRatingFacor(It.IsAny<int>())).Returns(1.0);
            IGetCustomerMonthlyPremium sutObj = new GetCustomerMonthlyPremium(_ratingsQuery.Object);

            // Act
            var result = sutObj.Execute(occupationId, age, sumInsured);

            // Assert
            Assert.Equal(250, result);
        }

        [Fact]
        public void When_GetCustomerMonthlyPremium_Is_Passed_Incorrect_Age_Returns_Zero()
        {
            int occupationId = 1002;
            int age = 0;
            double sumInsured = 100000;

            // Arrange
            _ratingsQuery.Setup(x => x.GetRatingFacor(It.IsAny<int>())).Returns(1.0);
            IGetCustomerMonthlyPremium sutObj = new GetCustomerMonthlyPremium(_ratingsQuery.Object);

            // Act
            var result = sutObj.Execute(occupationId, age, sumInsured);

            // Assert
            Assert.Equal(0, result);
        }

    }
}
