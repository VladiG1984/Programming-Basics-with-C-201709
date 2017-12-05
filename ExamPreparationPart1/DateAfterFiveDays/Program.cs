using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfterFiveDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int d2 = d + 5;
            int m2 = m;

            // February has 28 days
            if (m == 2)
            {
                // next month
                if (d2 > 28)
                {
                    d2 = d2 - 28;
                    m2 = m + 1;
                }
            }

            // months April, June, September, and November have 30 days
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                // next month
                if (d2 > 30)
                {
                    m2 = m + 1;
                    d2 = d2 - 30;
                }
            }

            else 
            {
                // next month
                if (d2 > 31)
                {
                    d2 = d2 - 31;
                    m2 = m + 1;
                }
            }

            if (m2 > 12) { m2 = 1; }
            
                Console.WriteLine("{0}.{1:D2}", d2, m2);

            
        }
    }
}
