using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var row1 = 1; row1 <= n; row1++)
            {
                //Console.Write(new string(' ', n - row1));
                for (int col1 = 1; col1 <= n - row1; col1++)
                {
                    Console.Write(' ');
                }
                Console.Write("*");
                for (var col1 = 1; col1 < row1; col1++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (var row2 = n - 1; row2 >= 1; row2--)
            {
                //Console.Write(new string(' ', n - row2));
                for (var col2 = 1; col2 <= n - row2; col2++)
                {
                    Console.Write(' ');
                }
                Console.Write("*");
                for (var col2 = 1; col2 < row2; col2++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
