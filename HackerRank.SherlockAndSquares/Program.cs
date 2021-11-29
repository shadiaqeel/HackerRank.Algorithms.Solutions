using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank.SherlockAndSquares
{

    /*
     * Watson likes to challenge Sherlock's math ability.
     * He will provide a starting and ending value that describe a range of integers, inclusive of the endpoints
     * . Sherlock must determine the number of square integers within that range.
     *Note: A square integer is an integer which is the square of an integer, e.g. .
     *Example
     *There are three square integers in the range:  and . Return .
     *
     */

    class Result
    {

        /*
         * Complete the 'squares' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER a
         *  2. INTEGER b
         *  
         *  
         */

        public static int squares(int a, int b)
        {
            var result = 0;
            var min = Math.Ceiling(Math.Sqrt(a));
            var max = Math.Sqrt(b);

            for (var i = min; i <= max; i++)
            {
                if ((i * i) <= b)
                    result++;
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
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int a = Convert.ToInt32(firstMultipleInput[0]);

                int b = Convert.ToInt32(firstMultipleInput[1]);

                int result = Result.squares(a, b);

                Console.WriteLine(result);
            }

        }
    }
}
