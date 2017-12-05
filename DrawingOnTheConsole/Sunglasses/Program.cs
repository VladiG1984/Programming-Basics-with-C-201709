using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stars = new string('*', (5 * n - n) / 2);
            var spaces = new string(' ', n);
            var vertical_lines = new string('|', n);
            var slashes = new string('/', (5 * n - n) / 2 - 2);

            // Console.WriteLine(stars + spaces + stars);
            for (var row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.WriteLine(stars + spaces + stars);
                }

                else if ((n % 2 == 0 && row == n / 2) || (n % 2 != 0 && row == (n + 1)/ 2)) 
                {
                    Console.Write("*");
                    Console.Write(slashes);
                    Console.Write("*");
                    Console.Write(vertical_lines);
                    Console.Write("*");
                    Console.Write(slashes);
                    Console.WriteLine("*");
                }

                else
                {
                    Console.Write("*");
                    Console.Write(slashes);
                    Console.Write("*");
                    Console.Write(spaces);
                    Console.Write("*");
                    Console.Write(slashes);
                    Console.WriteLine("*");
                }
            }
        }
    }
}
