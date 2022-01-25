using Moq;
using PremiumCalculator.Core.Occupations;
using PremiumCalculator.Core.Ratings;
using PremiumCalculator.Domain.Occupations;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PremiumCalculator.Api.Tests.Ratings
{
    public class GetRatingsTests
    {
        
        Mock<IOccupationQuery> _occupationsQuery;
        IGetRatingsQuery _ratingsQuery;


        public GetRatingsTests()
        {
            _occupationsQuery = new Mock<IOccupationQuery>();
            _ratingsQuery = new GetRatings(_occupationsQuery.Object);
        }

        [Fact]
        public void When_GetRatings_Executes_Should_Return_Correct_Data()
        {
            // Act
            var result = _ratingsQuery.Execute().ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(4, result.Count);
        }

        [Fact]
        public void When_GetRatingsFactor_Passes_Should_Return_Correct_Factor_Associated_With_Given_Occupation()
        {
            // Arrange
            int occupationId = 1002;
            _occupationsQuery.Setup(x => x.Execute()).Returns(TestOccupations());

            // Act
            var factor = _ratingsQuery.GetRatingFacor(occupationId);

            // Assert
            Assert.Equal(1.0, factor);
        }

        [Fact]
        public void When_GetRatingsFactor_Is_Passed_Incorrect_OccupationId_Should_Throw_NullReferenceException()
        {
            // Arrange
            int occupationId = 1111;
            _occupationsQuery.Setup(x => x.Execute()).Returns(TestOccupations());

            // Act and Assert
            Assert.Throws<NullReferenceException>(() => _ratingsQuery.GetRatingFacor(occupationId));
        }

        private IEnumerable<Occupation> TestOccupations()
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
