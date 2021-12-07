using System;
using System.Linq;
namespace HackerRank.FlatlandSpaceStations
{

    //URL : https://www.hackerrank.com/challenges/flatland-space-stations/problem?isFullScreen=true
    class Solution
        {

            // Complete the flatlandSpaceStations function below.
            static int flatlandSpaceStations(int n, int[] c)
            {

                var max = 0;
                var list = c.ToList();
                list.Sort();
                decimal diff = 0;
                var dis = 0;
                for (int i = 0; i < c.Count() - 1; i++)
                {

                    diff = Math.Abs((decimal)list[i] - list[i + 1]) / 2;
                    Console.WriteLine($"{list[i]}=>{list[i + 1]} : {diff}");
                    dis = (int)Math.Floor(diff);
                    max = Math.Max(max, dis);
                }

                //first one 
                diff = list[0];
                Console.WriteLine($"0=>{list[0]} : {diff}");
                max = (int)Math.Max(max, diff);

                //last one 
                diff = Math.Abs((decimal)(n - 1) - list[c.Count() - 1]);
                Console.WriteLine($"{n - 1}=>{list[c.Count() - 1]} : {diff}");
                max = (int)Math.Max(max, diff);


                return max;
            }

            static void Main(string[] args)
            {

                string[] nm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nm[0]);

                int m = Convert.ToInt32(nm[1]);

                int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
                ;
                int result = flatlandSpaceStations(n, c);

                Console.WriteLine(result);
            }
        }

    
}
