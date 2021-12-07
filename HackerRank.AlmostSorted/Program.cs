using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.AlmostSorted
{
    class Result
    {

        /* URL : https://www.hackerrank.com/challenges/almost-sorted/problem?isFullScreen=true
         * Complete the 'almostSorted' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void almostSorted(List<int> arr)
        {
            var sortedArr = arr.Select(i => i).ToList();
            sortedArr.Sort();
            var isReverse = false;
            var lower = 0;
            var lowerI = -1;
            var upper = 0;
            var upperI = -1;
            var canSort = true;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == sortedArr[i])
                    continue;
                if (lowerI == -1)
                {
                    //Console.WriteLine("Lower "+i);
                    lowerI = i;
                    lower = arr[i];
                    continue;
                }

                if (upperI != -1)
                {
                    isReverse = true;
                }
                if (isReverse && arr[i - 1] < arr[i])
                {
                    canSort = false;
                }


                //Console.WriteLine("Upper "+i);
                upperI = i;
                upper = arr[i];
            }

            if (canSort && isReverse)
            {

                canSort = IsMatch(arr.Skip(lowerI).Take(upperI - lowerI + 1).Reverse().ToList(), sortedArr.Skip(lowerI).Take(upperI - lowerI + 1).ToList());

            }

            Console.WriteLine(canSort ? "yes" : "no");
            if (canSort) Console.WriteLine($"{isReverse ? "reverse":"swap"} {lowerI+1 } {upperI+1}");
        }



        private static bool IsMatch(List<int> arr, List<int> sorted)
        {
            // Console.WriteLine("IsMatch");
            for (int i = 0; i < arr.Count; i++)
            {
                //Console.WriteLine(arr[i]+" "+sorted[i]);
                if (arr[i] != sorted[i])
                    return false;
            }
            return true;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.almostSorted(arr);
            
            
        }
    }
}
