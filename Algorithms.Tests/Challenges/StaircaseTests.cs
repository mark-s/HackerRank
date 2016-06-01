using Algorithms.Challenges;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Challenges
{
    [TestFixture]
    public class StaircaseTests
    {
        private Staircase _challenge;


        [SetUp]
        public virtual void SetUp()
        {
            _challenge = new Staircase();
        }

        [Test]
        public void ConstructStaircase_GivenHRInputs_Correct()
        {
            // Arrange

            // Act
            var result = _challenge.ConstructStaircase(6);
            
            // Assert
            result.ShouldBe("     #\r\n    ##\r\n   ###\r\n  ####\r\n #####\r\n######\r\n");

        }



        [Test]
        public void ConstructStaircaseEnumerable_GivenHRInputs_Correct()
        {
            // Arrange

            // Act
            var result = _challenge.ConstructStaircaseEnumerable(6);

            // Assert
            result.ShouldBe("     #\r\n    ##\r\n   ###\r\n  ####\r\n #####\r\n######\r\n");

        }
    }
}
