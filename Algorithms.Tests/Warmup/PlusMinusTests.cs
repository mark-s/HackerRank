using System;
using Algorithms.Warmup;
using NUnit.Framework;
using Shouldly;

namespace Algorithms.Tests.Warmup
{
    public class PlusMinusTests
    {
        private int _numItems = 6;
        private readonly int[] _items = { -4, 3, -9, 0, 4, 1 };
        private PlusMinus _challenge;
        private int _numberOrDecimalPlaces = 6;

        [SetUp]
        public virtual void SetUp()
        {
          _challenge = new PlusMinus();

        }


        [Test]
        public void FractionOfPositiveNumbers_ValuesFromHR_CorrectOutput()
        {
            // Arrange

            // Act
            var result = _challenge.FractionOfPositiveNumbers(_numItems, _items);
            var resultRounded =Math.Round(result, _numberOrDecimalPlaces);

            // Assert
            resultRounded.ShouldBe(0.500000);
        }

        [Test]
        public void FractionOfNegativeNumbers_ValuesFromHR_CorrectOutput()
        {
            // Arrange

            // Act
            var result = _challenge.FractionOfNegativeNumbers(_numItems, _items);
            var resultRounded = Math.Round(result, _numberOrDecimalPlaces);

            // Assert
            resultRounded.ShouldBe(0.333333);

        }
        
        [Test]
        public void FractionOfZeros_ValuesFromHR_CorrectOutput()
        {
            // Arrange

            // Act
            var result = _challenge.FractionOfZeros(_numItems, _items);
            var resultRounded = Math.Round(result, _numberOrDecimalPlaces);

            // Assert
            resultRounded.ShouldBe(0.166667);
        }

    }
}
