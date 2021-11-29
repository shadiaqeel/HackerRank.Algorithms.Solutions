using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.NonDivisibleSubset
{

    /* URL : https://www.hackerrank.com/challenges/non-divisible-subset/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
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
                    //We can add only one integer which is Reminders = k/2 because if we add two or more numbers then their sum will be k
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


    class Result2
    {

        /*
        * Complete the 'nonDivisibleSubset' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER k
        *  2. INTEGER_ARRAY s
        */

        public static long nonDivisibleSubset(int k, List<int> s)
        {
            int[] mk = new int[k];
            for (int i = 0; i < a.Length; i++) mk[a[i] % k]++;
            long x = 0;
            if (mk[0] > 0) x++;
            for (int i = 1; i < (k + 1) / 2; i++)
                x += Math.Max(mk[i], mk[k - i]);
            if (k % 2 == 0 && mk[k / 2] > 0) x++;
            return x;
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
