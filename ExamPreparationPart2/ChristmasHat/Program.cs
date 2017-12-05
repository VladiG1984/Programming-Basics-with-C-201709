using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string stars = new string('*', (4 * n + 1));
            string dots = new string('.', (4 * n + 1 - 3) / 2);
            string verticalSlash = "|";
            string slash = @"\"; // the symbol @ plus the symbol in quotation marks removes the special 
                                 // meaning of the symbol in the quotation marks (here, new line)
            string backSlash = "/";

            Console.WriteLine(dots + backSlash + verticalSlash + slash + dots);
            Console.WriteLine(dots + slash + verticalSlash + backSlash + dots);

            for (int i = 1; i <= 2 * n; i++)
            {
                string innerDots = new string('.', 2 * n - i);
                string innerDash = new string('-', i - 1);
                string innerStar = "*";

                Console.WriteLine(innerDots + innerStar + innerDash + innerStar + innerDash + 
                                    innerStar + innerDots);
            }

            Console.WriteLine(stars);
            Console.Write("*");
            for (int k = 0; k < 2 * n; k++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(stars);
        }
    }
}
