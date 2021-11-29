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

class Result
{

    /*
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     *  3. INTEGER k
     */

    public static string appendAndDelete(string s, string t, int k)
    {
        if (s.Count() + t.Count() <= k) return "Yes";

        while (k != 0)
        {
            if (s.StartsWith(t))
            {
                if (s == t)
                {
                    Console.WriteLine("Yes " + t);
                    break;
                }
                else
                {
                    k--;
                    t = t + s[t.Count()];
                    continue;
                }
            }

            k--;
            t = t.Remove(t.Count() - 1);

        }

        if (s == t && k == 0) return "Yes";
        if (s == t && k % 2 == 0) return "Yes";


        return "No";
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

     
    }
}
