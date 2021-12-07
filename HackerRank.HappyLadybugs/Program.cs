using System;
using System.IO;
using System.Linq;
namespace HackerRank.HappyLadybugs
{
    // URL  : https://www.hackerrank.com/challenges/happy-ladybugs/problem?isFullScreen=true
    class Result
    {

        /*
         * Complete the 'happyLadybugs' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING b as parameter.
         */

        public static string happyLadybugs(string b)
        {

            var result = true;
            if (b.Count(c => c == '_') == 0)
            {
                result = AllHappyLadybugs(b);
            }
            else
            {
                var list = b.ToList();
                list.Sort();
                b = new String(list.ToArray());
                result = AllHappyLadybugs(b);
            }
            return result ? "YES" : "NO";


        }
        private static bool AllHappyLadybugs(string b)
        {

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '_')
                    continue;

                if (i != b.Length - 1 && b[i + 1] == b[i])
                {
                    continue;
                }
                else if (i != 0 && b[i - 1] == b[i])
                {
                    continue;
                }
                else
                    return false;

            }
            return true;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            /* INPUT : 
             * 4
             * 7
             * RBY_YBR
             * 6
             * X_Y__X
             * 2
             * __
             * 6
             * B_RRBR
             */

            int g = Convert.ToInt32(Console.ReadLine().Trim());

            for (int gItr = 0; gItr < g; gItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                string b = Console.ReadLine();

                string result = Result.happyLadybugs(b);

                Console.WriteLine(result);
            }

        }
    }

}
