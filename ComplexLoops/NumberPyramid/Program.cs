using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            bool hasToEnd = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (num <= n) { Console.Write(num++ + " "); }
                    
                    else { hasToEnd = true; if (j > 1) { Console.WriteLine(); } break; } // add new line if result includes incomplete row
                }
                Console.WriteLine(); // move pointer to a new line after filling the row with numbers

                if (hasToEnd == true) { break; } // break the outer loop whenever sum of numbers equals the number entered in the console input
            }

            if (n == 1) { Console.WriteLine(); } // add new line whenever only one row of numbers is the output (this is so because outer loop executes only once

        }
    }
}
