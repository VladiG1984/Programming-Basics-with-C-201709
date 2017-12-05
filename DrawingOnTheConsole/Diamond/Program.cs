using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (var row = 1; row <= n / 2; row++)
                {
                    var outer_dashes = new string('-', n / 2 - row);
                    var middle_dashes = new string('-', n - (n / 2 - row) * 2 - 2);

                    Console.Write(outer_dashes);
                    Console.Write("*");
                    Console.Write(middle_dashes);
                    Console.Write("*");
                    Console.WriteLine(outer_dashes);
                }

                for (var row = n / 2 + 1; row <= n - 1; row++)
                {
                    var outer_dashes = new string('-', -1 * (n / 2 - row));
                    var middle_dashes = new string('-', n + (n / 2 - row) * 2 - 2);

                    Console.Write(outer_dashes);
                    Console.Write("*");
                    Console.Write(middle_dashes);
                    Console.Write("*");
                    Console.WriteLine(outer_dashes);
                }
            }

            else
            {
                for (var row = 1; row <= (n + 1) / 2; row++)
                {
                    var outer_dashes = new string('-', (n + 1) / 2 - row);
                    var middle_dashes = new string('-', Math.Max(0, n - ((n + 1) / 2 - row) * 2 - 2));
                     
                    Console.Write(outer_dashes);
                    Console.Write("*");
                    Console.Write(middle_dashes);
                    if (row != 1) { Console.Write("*"); }
                    Console.WriteLine(outer_dashes);
                }

                for (var row = (n + 1) / 2 + 1; row <= n; row++)
                {
                    var outer_dashes = new string('-', -1 * ((n + 1) / 2 - row));
                    var middle_dashes = new string('-', Math.Max(0, n + ((n + 1) / 2 - row) * 2 - 2));

                    Console.Write(outer_dashes);
                    Console.Write("*");
                    Console.Write(middle_dashes);
                    if (row != n) { Console.Write("*"); }
                    Console.WriteLine(outer_dashes);
                }
            }
        }
    }
}
