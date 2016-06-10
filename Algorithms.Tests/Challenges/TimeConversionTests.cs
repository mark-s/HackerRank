using Algorithms.Challenges;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Challenges
{
    public class TimeConversionTests
    {
        private TimeConversion _challenge;


        [SetUp]
        public virtual void SetUp()
        {
            _challenge = new TimeConversion(); 
        }


        [Test]
        public void GivenHackerRankTest_CorrectlyParses()
        {
            // Arrange
            var timeString = "07:05:45PM";

            // Act
            var result = _challenge.ConvertToMilitaryTime(timeString);

            // Assert
            result.ShouldBe("19:05:45");
        }



    }
}
