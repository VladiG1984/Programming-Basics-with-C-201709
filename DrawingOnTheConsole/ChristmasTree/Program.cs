using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n + 1; row++)
            {
                for (int col = 1; col <= n + 1 - row; col++)
                {
                    Console.Write(' ');
                }

                for (int col = 2; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int col = 2; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
