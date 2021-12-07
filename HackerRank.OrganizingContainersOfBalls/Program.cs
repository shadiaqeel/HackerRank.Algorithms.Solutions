using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.OrganizingContainersOfBalls
{

    class Result
    {

        /*
         * Complete the 'organizingContainers' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts 2D_INTEGER_ARRAY container as parameter.
         */

        public static string organizingContainers(List<List<int>> container)
        {
            var result = "Possible";
            var xSum = new List<long>();
            var ySum = new List<long>();
            for (int i = 0; i < container.Count; i++)
            {
                long xDir = 0;
                long yDir = 0;
                for (int j = 0; j < container[i].Count; j++)
                {
                    yDir += container[j][i];
                    xDir += container[i][j];
                }

                xSum.Add(xDir);
                ySum.Add(yDir);

            }

            xSum.Sort();
            ySum.Sort();

            for (int i = 0; i < xSum.Count; i++)
            {
                if (xSum[i] != ySum[i])
                    return "Impossible";
            }
            return result;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<List<int>> container = new List<List<int>>();

                for (int i = 0; i < n; i++)
                {
                    container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
                }

                string result = Result.organizingContainers(container);

                Console.WriteLine(result);
            }

        }
    }

}
