using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.BigSort
{
    //URL : https://www.hackerrank.com/challenges/big-sorting/problem?isFullScreen=true
    class Result
    {

        /*
         * Complete the 'bigSorting' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts STRING_ARRAY unsorted as parameter.
         */

        public static List<string> bigSorting(List<string> unsorted)
        {
            var arr = unsorted.ToArray();
            Array.Sort(arr, (string a, string b) =>
            {
                if (a.Length == b.Length)
                    return string.Compare(a, b, StringComparison.Ordinal);
                return a.Length - b.Length;
            });
            return arr.ToList();

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> unsorted = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted.Add(unsortedItem);
            }

            List<string> result = Result.bigSorting(unsorted);

            Console.WriteLine(String.Join("\n", result));

        }
    }

}
