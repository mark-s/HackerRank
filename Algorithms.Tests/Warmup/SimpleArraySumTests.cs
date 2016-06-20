using Algorithms.Warmup;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Warmup
{

    [TestFixture]
    public class SimpleArraySumTests
    {
        private SimpleArraySum _challenge;

        [SetUp]
        public virtual void SetUp()
        {
            _challenge = new SimpleArraySum();
        }



        [Test]
        public void SumAll_ValuesFromHR_CorrectOutput()
        {
            // Arrange
            var numItems = 6;
            var numbers = new[] {1, 2, 3, 4, 10, 11};

            // Act
            var result = _challenge.SumAll(numItems, numbers);

            // Assert
            result.ShouldBe(31);
        }


    }
}
