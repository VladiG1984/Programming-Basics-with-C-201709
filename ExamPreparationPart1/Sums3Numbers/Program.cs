using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int a = Math.Min(Math.Min(x, y), z);
            int c = Math.Max(Math.Max(x, y), z);
            int sum = x + y + z;
            int b = sum - (a + c);

            if (sum - c == c)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, c);
            }

            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
