namespace Algorithms.Challenges
{

    // https://www.hackerrank.com/challenges/simple-array-sum
    public class SimpleArraySum
    {
        public int SumAll(int lengthOfArray, int[] numbers)
        {
            var sum = 0;

            for (var i = 0; i < lengthOfArray; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
