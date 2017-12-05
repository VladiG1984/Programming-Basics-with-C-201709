using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //draw smoke
            for (int i = 1; i <= n; i++)
            {
                string spacesFront = new string(' ', n);
                string spacesBack = new string(' ', n * 2);

                Console.Write(spacesFront);

                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("~ ");
                }

                Console.WriteLine(spacesBack);
            }

            //draw cup's body
            string equalsignsTop = new string('=', 3 * n + 6 - 1);

            Console.WriteLine(equalsignsTop);

            //odd n
            //if (n % 2 != 0)
            //{
            //for (int k = 1; k <= n - 3 / 2; k++)
            //{
            //  Console.Write("|");

            //}
            //}

            for (int k = 1; k <= n - 2; k++)
            {
                char verticalLine = '|';
                string waves = new string('~', n);
                string logo = "JAVA";
                string handleCup = new string(' ', n - 1);

                if ((n % 2 != 0 && k == (n - 1) / 2) || (n % 2 == 0 && k == ((n - 2) / 2 + 1)))
                {
                    Console.WriteLine(verticalLine + waves + logo + waves + verticalLine + handleCup + verticalLine);
                }

                else
                {
                    Console.WriteLine(verticalLine + waves + "~~~~" + waves + verticalLine + handleCup + verticalLine);
                }

            }

            Console.WriteLine(equalsignsTop);

            //draw cup's bottom part (6 + 2 * (n - 1))

            for (int l = 0; l < n; l++)
            {
                //front spaces
                //for (int m = 0; m < l; m++)
                //{
                  //  Console.Write(' ');
                //}

                string innerSpaces = new string(' ', l);

                Console.Write(innerSpaces);

                //back slash sign
                Console.Write(@"\");

                //@ signs
                string monkeys = new string('@', 3 * n + 6 - (n + 2 + (l) * 2));

                Console.Write(monkeys);

                //slash sign
                Console.WriteLine("/");

            }

            //draw bottom
            string bottomPart = new string('=', 2 * n + 6);

            Console.WriteLine(bottomPart);

        }
    }
}
