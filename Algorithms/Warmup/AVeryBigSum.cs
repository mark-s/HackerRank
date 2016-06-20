namespace Algorithms.Warmup
{
    public class AVeryBigSum
    {
        // https://www.hackerrank.com/challenges/a-very-big-sum

        public long SumAll(int lengthOfArray, long[] numbers)
        {
            var sum = 0L;

            for (var i = 0; i < lengthOfArray; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }


    
}
