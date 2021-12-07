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
using System.Threading;

class Result
{

    /*
     * Complete the 'queensAttack' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER queenY
     *  4. INTEGER queenX
     *  5. 2D_INTEGER_ARRAY obstacles
     */

    public static int queensAttack(int n, int k, int queenX, int queenY, List<List<int>> obstacles)
    {
        int count = GetCellCanAttackCount(queenX, queenY, n);
        Console.WriteLine(count);
        count -= GetCellCannotAttackCount(obstacles, queenX, queenY, n);
        return count;
    }
    private static int GetCellCanAttackCount(int queenX, int queenY, int k)
    {
        int orthognals = (2 * k) - 2;
        Console.WriteLine($"orthognals = {orthognals}");
        int diagonals = ((2 * k) - 2) - Math.Abs(queenX - queenY) - Math.Abs(queenX + queenY - k - 1);
        Console.WriteLine($"diagonals = {diagonals}");
        return orthognals + diagonals;
    }

    private static int GetCellCannotAttackCount(List<List<int>> obstacles , int queenX , int queenY , int k)
    {

        int u = 0 , ur = 0 , ul = 0, r = 0, dr= 0 , d = 0 , dl =0 , l = 0;
        int diff = 0;
        foreach (var obstacle in obstacles)
        {
            if (obstacle[0] == queenX && obstacle[1] > queenY)
            {
                u = Math.Max( u ,(k - obstacle[1] + 1));
                Console.WriteLine($"(x,y+1) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");
            }
            else if (obstacle[0] > queenX && obstacle[1] > queenY && (obstacle[0] - obstacle[1]) == (queenX - queenY))
            {
                diff = Math.Min(k - obstacle[0] + 1, k - obstacle[1] + 1);
                ur = Math.Max(ur, diff);
                Console.WriteLine($"(x+1,y+1) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");
            }
            else if (obstacle[0] > queenX && obstacle[1] == queenY)
            {
                diff = (k - obstacle[0] + 1);
                r = Math.Max(r, diff);
                Console.WriteLine($"(x+1,y) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");

            }
            else if (obstacle[0] > queenX && obstacle[1] < queenY && (obstacle[0] + obstacle[1]) == (queenX + queenY))
            {
                diff = Math.Min(k - obstacle[0] + 1, obstacle[1]);
                dr = Math.Max(dr, diff);
                Console.WriteLine($"(x+1,y-1) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");

            }
            else if (obstacle[0] == queenX && obstacle[1] < queenY)
            {
                diff = obstacle[1];
                d = Math.Max(d, diff);
                Console.WriteLine($"(x,y-1) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");

            }
            else if (obstacle[0] < queenX && obstacle[1] < queenY && (obstacle[0] - obstacle[1]) == (queenX - queenY))
            {
                diff = Math.Min(obstacle[0], obstacle[1]);
                dl = Math.Max(dl, diff);
                Console.WriteLine($"(x-1,y-1) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");


            }
            else if (obstacle[0] < queenX && obstacle[1] == queenY)
            {
                diff = obstacle[0];
                l = Math.Max(l, diff);
                Console.WriteLine($"(x-1,y) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");

            }
            else if (obstacle[0] < queenX && obstacle[1] > queenY && (obstacle[0] + obstacle[1]) == (queenX + queenY))
            {
                diff = Math.Min(obstacle[0], k - obstacle[1] + 1);
                ul = Math.Max(ul, diff);
                Console.WriteLine($"(x-1,y+1) | {obstacle[0]}:{obstacle[1]} | diff = {diff}");


            }
            Console.WriteLine(u + ur + ul + r + dr + d + dl + l);
        }
        return u + ur + ul + r + dr + d + dl + l;;

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int queenY = Convert.ToInt32(secondMultipleInput[0]);

        int queenX = Convert.ToInt32(secondMultipleInput[1]);

        List<List<int>> obstacles = new List<List<int>>();

        for (int i = 0; i < k; i++)
        {
            obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
        }

        int result = Result.queensAttack(n, k, queenY, queenX, obstacles);

        Console.WriteLine(result);
    }
}
