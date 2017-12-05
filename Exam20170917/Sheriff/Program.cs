using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string row1Dots = new string('.', (3 * n - 1) / 2);
            string row2Dots = new string('.', (3 * n - 1) / 2 - 1);
            string x = "x";
            string slash = "/";
            string backSlash = @"\";
            string verticalSlash = "|";

            // static rows - beginning
            Console.WriteLine(row1Dots + x + row1Dots);
            Console.WriteLine(row2Dots + slash + x + backSlash + row2Dots);
            Console.WriteLine(row2Dots + x + verticalSlash + x + row2Dots);

            // dynamic rows - increasing
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                string innerX = new string('x', i + (n - 1));
                string innerDots = new string('.', (3 * n - (2 * (i + (n - 1)) + 1)) / 2);

                Console.WriteLine(innerDots + innerX + verticalSlash + innerX + innerDots);
            }

            // dynamic rows - decreasing
            for (int j = (n - 1) / 2; j >= 1; j--)
            {
                string innerX = new string('x', j + (n - 1));
                string innerDots = new string('.', (3 * n - (2 * (j + (n - 1)) + 1)) / 2);

                Console.WriteLine(innerDots + innerX + verticalSlash + innerX + innerDots);
            }

            // static rows - middle
            Console.WriteLine(row2Dots + slash + x + backSlash + row2Dots);
            Console.WriteLine(row2Dots + backSlash + x + slash + row2Dots);

            // dynamic rows - increasing
            for (int k = 1; k <= (n + 1) / 2; k++)
            {
                string innerX = new string('x', k + (n - 1));
                string innerDots = new string('.', (3 * n - (2 * (k + (n - 1)) + 1)) / 2);

                Console.WriteLine(innerDots + innerX + verticalSlash + innerX + innerDots);
            }

            // dynamic rows - decreasing
            for (int l = (n - 1) / 2; l >= 1; l--)
            {
                string innerX = new string('x', l + (n - 1));
                string innerDots = new string('.', (3 * n - (2 * (l + (n - 1)) + 1)) / 2);

                Console.WriteLine(innerDots + innerX + verticalSlash + innerX + innerDots);
            }

            // static rows - end
            Console.WriteLine(row2Dots + x + verticalSlash + x + row2Dots);
            Console.WriteLine(row2Dots + backSlash + x + slash + row2Dots);
            Console.WriteLine(row1Dots + x + row1Dots);
        }
    }
}
