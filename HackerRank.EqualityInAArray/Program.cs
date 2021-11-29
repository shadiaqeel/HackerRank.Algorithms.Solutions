using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.EqualityInAArray
{
    /* Given an array of integers, determine the minimum number of elements to delete to leave only elements of equal value. */
    class Result
    {

        /*
         * Complete the 'equalizeArray' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int equalizeArray(List<int> arr)
        {
            // var repeatedNum =
            var repeatedNum = 0;
            var repeatCount = 0;
            var groups = arr.GroupBy(i => i);
            foreach (var grp in groups)
            {
                if (grp.Count() > repeatCount)
                {
                    repeatCount = grp.Count();
                    repeatedNum = grp.Key;
                }
            }
            Console.WriteLine(repeatedNum);

            return arr.Where(i => i != repeatedNum).Count();
        }


    }



    class Solution
    {
        public static void Main(string[] args)
        {
            /*
             * Input
             * 5
             * 3 3 2 1 3
             */
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.equalizeArray(arr);
            Console.WriteLine(result);

        }
    }

}
