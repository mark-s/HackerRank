namespace Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/kangaroo

    internal class KangarooStats
    {
        public int JumpDistance { get; set; }
        public int CurrentLocation { get; set; }
    }


    public class Kangaroo
    {

        public string HackerRankInputHandler(int x1, int v1, int x2, int v2)
        {
            var kangaroo1 = new KangarooStats { CurrentLocation = x1, JumpDistance = v1 };
            var kangaroo2 = new KangarooStats { CurrentLocation = x2, JumpDistance = v2 };


            if (kangaroo1.CurrentLocation < kangaroo2.CurrentLocation && kangaroo1.JumpDistance <= kangaroo2.JumpDistance)
                return "NO";

            return (kangaroo1.CurrentLocation - kangaroo2.CurrentLocation) % (kangaroo1.JumpDistance - kangaroo2.JumpDistance)
                        == 0 ? "YES" : "NO";
        }


    }
}
