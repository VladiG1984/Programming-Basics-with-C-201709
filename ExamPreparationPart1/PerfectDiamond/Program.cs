using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int k = 0; k < i; k++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int k = 0; k < i; k++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
