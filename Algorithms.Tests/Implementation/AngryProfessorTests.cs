using Algorithms.Implementation;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Implementation
{
    public class AngryProfessorTests
    {
        private AngryProfessor _challenge;

        [SetUp]
        public virtual void SetUp()
        {
            _challenge = new AngryProfessor();
        }


        [Test]
        public void IsCancelled_GivenHRCaseOne_Cancelled()
        {
            // Arrange
            int numStudentsRequired = 3;
            int[] arrivalTimes = {-1, -3, 4, 2};

            // Act
            var isCancelled = _challenge.IsCancelled(numStudentsRequired, arrivalTimes);


            // Assert
            isCancelled.ShouldBe("YES");
        }

        [Test]
        public void IsCancelled_GivenHRCaseTwo_NotCancelled()
        {
            // Arrange
            int numStudentsRequired = 2;
            int[] arrivalTimes = { 0, -1, 2, 1 };

            // Act
            var isCancelled = _challenge.IsCancelled(numStudentsRequired, arrivalTimes);


            // Assert
            isCancelled.ShouldBe("NO");
        }

    }
}
