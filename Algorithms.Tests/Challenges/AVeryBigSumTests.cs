using Algorithms.Challenges;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Challenges
{

    [TestFixture]
    public class AVeryBigSumTests
    {
        private AVeryBigSum _challenge;

        [SetUp]
        public virtual void SetUp()
        {
            _challenge = new AVeryBigSum();
        }



        [Test]
        public void SumAll_ValuesFromHR_CorrectOutput()
        {
            // Arrange
            var numItems = 5;
            var numbers = new[] {1000000001, 1000000002, 1000000003, 1000000004, 1000000005L};

            // Act
            var result = _challenge.SumAll(numItems, numbers);

            // Assert
            result.ShouldBe(5000000015);
        }
    }

}
