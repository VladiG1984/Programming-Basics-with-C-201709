using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // even numbers
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n + 1; i++)
                {
                    if (i == 1 || i == n + 1)
                    {
                        Console.WriteLine(new string('%', 2 * n));
                    }

                    else if (i == n / 2 + 1)
                    {
                        Console.Write('%');
                        Console.Write(new string(' ', n - 2));
                        Console.Write("**");
                        Console.Write(new string(' ', n - 2));
                        Console.WriteLine('%');
                    }

                    else
                    {
                        Console.Write('%');
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.WriteLine('%');
                    }
                }
            }

            // odd numbers
            if (n % 2 != 0)
            {
                for (int i = 1; i <= n + 2; i++)
                {
                    if (i == 1 || i == n + 2)
                    {
                        Console.WriteLine(new string('%', 2 * n));
                    }

                    else if (i == (n + 1)/ 2 + 1)
                    {
                        Console.Write('%');
                        Console.Write(new string(' ', n - 2));
                        Console.Write("**");
                        Console.Write(new string(' ', n - 2));
                        Console.WriteLine('%');
                    }

                    else
                    {
                        Console.Write('%');
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.WriteLine('%');
                    }
                }
            }
        }
    }
}
