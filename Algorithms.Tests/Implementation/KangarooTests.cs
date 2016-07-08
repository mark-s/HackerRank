using Algorithms.Implementation;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Implementation
{

    [TestFixture]
    public class KangarooTests
    {
        private Kangaroo _challenge;

        [SetUp]
        public virtual void SetUp()
        {

            _challenge = new Kangaroo();
        }

        [Test]
        public void GivenHAackerRankInput1_GivesYES()
        {
            // Arrange
            var x1 = 0;
            var v1 = 3;
            var x2 = 4;
            var v2 = 2;

            // Act
            var result = _challenge.HackerRankInputHandler(x1, v1, x2, v2);

            // Assert
            result.ShouldBe("YES");
        }

        [Test]
        public void GivenHAackerRankInput2_GivesNO()
        {
            // Arrange
            var x1 = 0;
            var v1 = 2;
            var x2 = 5;
            var v2 = 3;

            // Act
            var result = _challenge.HackerRankInputHandler(x1, v1, x2, v2);

            // Assert
            result.ShouldBe("NO");
        }

        [Test]
        public void GivenHAackerRankInput10_GivesNO()
        {
            // 43 2 70 2
            // Arrange
            var x1 = 43;
            var v1 = 2;
            var x2 = 70;
            var v2 = 2;

            // Act
            var result = _challenge.HackerRankInputHandler(x1, v1, x2, v2);

            // Assert
            result.ShouldBe("NO");
        }

        [Test]
        public void GivenHAackerRankInput21_GivesYES()
        {
            // Arrange
            var x1 = 4602;
            var v1 = 8519;
            var x2 = 7585;
            var v2 = 8362;

            // Act
            var result = _challenge.HackerRankInputHandler(x1, v1, x2, v2);

            // Assert
            result.ShouldBe("YES");
        }

    }
}
