using System;

namespace Algorithms.Warmup
{

    // https://www.hackerrank.com/challenges/diagonal-difference
    public class DiagonalDifference
    {
        public int CalculateDiagonalDifference(int length, int[][] ints)
        {
            var sumDiagonal1 = 0;

            for (int i = 0; i < length; i++)
            {
                sumDiagonal1 += ints[i][i];
            }


            var sumDiagonal2 = 0;
            var row = length;

            for (int column = 0; column < length; column++)
            {
                sumDiagonal2 += ints[--row][column];
            }

            return Math.Abs(sumDiagonal1 - sumDiagonal2);
        }
    }
}
