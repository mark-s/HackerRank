using System;

namespace Algorithms.Warmup
{
    // https://www.hackerrank.com/challenges/time-conversion
    public class TimeConversion
    {

        public string ConvertToMilitaryTime(string timeString)
        {
            DateTime parsedTime;
            if (DateTime.TryParse(timeString, out parsedTime))
                return parsedTime.ToString("HH:mm:ss");
            else
                throw new ArgumentException("please provide a valid time hh:mm:ssTT", nameof(timeString));
        }
    }
}
