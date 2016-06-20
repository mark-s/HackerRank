using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/angry-professor

    public class AngryProfessor
    {
        private const string TRUE = "YES";
        private const string FALSE = "NO";


        // Code in the Hacker Rank page
        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //
        //    for (int a0 = 0; a0 < t; a0++)
        //    {
        //        string[] tokens_n = Console.ReadLine().Split(' ');
        //        int k = Convert.ToInt32(tokens_n[1]);
        //        string[] a_temp = Console.ReadLine().Split(' ');
        //        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //
        //        Console.WriteLine(IsCancelled(k, a));
        //    }
        //
        //}





        public string IsCancelled(int numberOfOnTimeStudentsRequired, IEnumerable<int> arrivalTimes)
        {
            var numberOfStudentsOnTime = arrivalTimes.Count(WasOnTime);


            if (numberOfOnTimeStudentsRequired > numberOfStudentsOnTime)
                return TRUE;
            else
                return FALSE;
        }

        private bool WasOnTime(int timeOfArrival)
        {
            return timeOfArrival <= 0;
        }


    }
}
