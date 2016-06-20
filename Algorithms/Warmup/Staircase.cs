using System;
using System.Linq;

namespace Algorithms.Warmup
{
    // https://www.hackerrank.com/challenges/staircase
    public class Staircase
    {
        public string ConstructStaircase(int steps)
        {
            var staircase = "";

            var emptyStairSpace = ' ';
            var solidStairSpace = '#';

            for (int i = 1; i <= steps; i++)
            {
                staircase += string.Concat(
                                                new string(emptyStairSpace, steps - i),
                                                new string(solidStairSpace, i ),
                                                Environment.NewLine);

            }
            return staircase;
        }


        public string ConstructStaircaseEnumerable(int steps)
        {
            var staircase = "";

            var emptyStairSpace = ' ';
            var solidStairSpace = '#';

            for (int i = 1; i <= steps; i++)
            {
                staircase += string.Concat(string.Concat(Enumerable.Repeat(emptyStairSpace, steps-i)),
                                                          string.Concat(Enumerable.Repeat(solidStairSpace, i)),
                                                          Environment.NewLine);

            }
            return staircase;
        }

    }

}
