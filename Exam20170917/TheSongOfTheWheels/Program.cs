using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            int counter = 0;
            string password = "";

            for (int a = 1; a < 9; a++)
            {
                for (int b = a + 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= c - 1; d++)
                        {
                            if (a * b + c * d == m)
                            {
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                                counter++;

                                if (counter == 4)
                                {
                                    password = string.Format("{0}{1}{2}{3}", a, b, c, d);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (counter >= 4)
            {
                Console.WriteLine("Password: {0}", password);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
