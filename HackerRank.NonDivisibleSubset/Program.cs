using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.NonDivisibleSubset
{

    /* 
     * Given a set of distinct integers,
     * print the size of a maximal subset of  where the sum of any  numbers in  is not evenly divisible by .
     * Example
     * One of the arrays that can be created is .
     * Another is .
     * After testing all permutations, the maximum length solution array has  elements.
     * */

    class Result
    {


        /*
         * Complete the 'nonDivisibleSubset' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY s
         */

        public static int nonDivisibleSubset(int k, List<int> s)
        {
            var reminders = new int[k];
            for (int i = 0; i < s.Count; i++)
            {
                int num = s[i];
                int index = num % k;
                reminders[index]++;
                Console.WriteLine($"index = {index} , reminder = {reminders[index]}");
            }
            int size = 0;
            for (int i = 1; i <= k / 2; i++)
            {
                Console.WriteLine($"i = {i}");
                if (i * 2 == k)
                {
                    size++;
                }
                else
                {
                    size += Math.Max(reminders[i], reminders[k - i]);
                }
            }
            return reminders[0] != 0 ? size + 1 : size;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            /*
             *  Input
             *  15 7
             *  278 576 496 727 410 124 338 149 209 702 282 718 771 575 436
             *
             */

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = Result.nonDivisibleSubset(k, s);

            Console.WriteLine(result);
        }
    }

}
