using Algorithms.Warmup;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Warmup
{
    public class DiagonalDifferenceTests
    {
        private DiagonalDifference _challenge;

        [SetUp]
        public virtual void SetUp()
        {

            _challenge = new DiagonalDifference();

        }

        [Test]
        public void CalculateDiagonalDifference_ValuesFromHR_CorrectOutput()
        {
            // Arrange
            var dimensions = 3;
            var lines = new[] { new[] { 11, 2, 4 }, new[] { 4, 5, 6 }, new[] { 10, 8, -12 } };

            // Act
            var result =_challenge.CalculateDiagonalDifference(dimensions, lines);

            // Assert
            result.ShouldBe(15);
        }

    }
}
