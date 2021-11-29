using System;
using System.Linq;

namespace HackerRank.BeautifulDaysAtTheMovies
{

    class Result
    {

        /*
         * Complete the 'beautifulDays' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER i
         *  2. INTEGER j
         *  3. INTEGER k
         */
        public static int Reverse(int x)
        {

            int n = x;
            int m = 0;
            while (x > 0)
            {
                m = m * 10 + x % 10;
                x /= 10;
            }
            return m;
        }

        public static int BeautifulDays(int i, int j, int k)
        {
            var day = i;
            var beautifulDaysCount = 0;


            while (day <= j)
            {
                var diff = Math.Abs(day - Reverse(day));
                if (diff % k == 0)
                    beautifulDaysCount++;

                day++;
            }

            return beautifulDaysCount;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = Result.BeautifulDays(1, 2000000, 23047885);
            Console.WriteLine("Result : " + result);

        }
    }
}
