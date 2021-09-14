using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies
{
    class Solution
    {
        public int CalPoints(string[] ops)
        {
            //int previous = 0;
            var arry = new List<int>();
            int newnum = 0;
            foreach(string bet in ops)
            {
                if(bet=="D"){
                    int xn = arry.Count();
                    arry.Add( (2 * arry[xn - 1]));
                    //previous = arry[xn];
                    Console.WriteLine(arry);
                }
                else if (bet == "+")
                {
                    int xn = arry.Count();
                    arry.Add((arry[xn - 2] + arry[xn - 1]));
                    //previous = arry[xn];
                    Console.WriteLine(arry);
                }
                else if (bet=="C")
                {
                    int xn = arry.Count();
                    var ay = new List<int>();
                    for(int nv=0; nv<xn-1;nv++)
                    {
                        ay.Add(arry[nv]);
                    }
                    arry = ay;
                    //previous = 0;
                    Console.WriteLine(arry);
                }
                else if (int.TryParse(bet, out newnum )==true)
                {
                    int xn = arry.Count();
                    arry.Add(newnum);
                    Console.WriteLine(arry);
                    //previous = newnum;
                }
            }
            int sum = arry.Sum();
            //foreach(int sb in arry)
            //{
            //    Console.WriteLine(sb);
            //}

            return sum;
        }
        public int CountElements(int[] arr)
        {

            return 0;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[] space = new char[] { ' ' };
            string[] ops = Console.ReadLine().Split(space);
            int output = solution.CalPoints(ops);
            Console.Write(output.ToString());
            Console.WriteLine(output);
            Console.WriteLine(output);

            //The Second Example
            //Solution solution = new Solution();
            //char[] space = new char[] { ' ' };
            //string input = Console.ReadLine().Split(space);
            //int[] arr = input.ToList().Select(int.Parse).ToArray();
            //int output = solution.CountElements(arr);
        }
    }
}
