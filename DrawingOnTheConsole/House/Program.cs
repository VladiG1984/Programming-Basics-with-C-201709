using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
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
                    var stars = new string('*', row * 2);
                    var dashes = new string('-', (n - row * 2) / 2);

                    Console.Write(dashes);
                    Console.Write(stars);
                    Console.WriteLine(dashes);
                }

                for (var row = (n / 2) + 1; row <= n; row++)
                {
                    var stars = new string('*', n - 2);

                    Console.Write("|");
                    Console.Write(stars);
                    Console.WriteLine("|");
                }
            }

            else 
            {
                for (var row = 1; row <= (n + 1)/ 2; row++)
                {
                    var stars = new string('*', row * 2 - 1);
                    var dashes = new string('-', (n - (row * 2 - 1)) / 2);

                    Console.Write(dashes);
                    Console.Write(stars);
                    Console.WriteLine(dashes);
                }

                for (var row = ((n + 1)/ 2) + 1; row <= n; row++)
                {
                    var stars = new string('*', n - 2);

                    Console.Write("|");
                    Console.Write(stars);
                    Console.WriteLine("|");
                }
            }
        }
    }
}
