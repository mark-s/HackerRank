using System;
using System.Linq;

namespace Algorithms.Challenges
{
    public class PlusMinus
    {

        public void OutPutResults(int howManyNumbers, int[] numbers)
        {
            var pos = FractionOfPositiveNumbers(howManyNumbers, numbers);
            var neg = FractionOfNegativeNumbers(howManyNumbers, numbers);
            var zeros = FractionOfZeros(howManyNumbers, numbers);

            Console.WriteLine(pos.ToString("N6"));
            Console.WriteLine(neg.ToString("N6"));
            Console.WriteLine(zeros.ToString("N6"));
        }


        public float FractionOfPositiveNumbers(int howManyNumbers, int[] numbers)
        {
            float numPos = numbers.Where(n => n > 0).Count();

            return numPos / howManyNumbers;
        }

        public float FractionOfNegativeNumbers(int howManyNumbers, int[] numbers)
        {
            float numNeg = numbers.Where(n => n < 0).Count();

            return numNeg / howManyNumbers;
        }

        public float FractionOfZeros(int howManyNumbers, int[] numbers)
        {
            float numZeros = numbers.Where(n => n == 0).Count();

            return numZeros / howManyNumbers;
        }

    }
}
