using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double minNumberEven = 0;
            double maxNumberEven = 0;
            double sumEven = 0;

            double minNumberOdd = 0;
            double maxNumberOdd = 0;
            double sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                /* even-position numbers */
                if (i % 2 == 0)
                {
                    sumEven += num;

                    /*first even-position number*/
                    if (i == 2) { minNumberEven = num; maxNumberEven = num; }
                    else
                    {
                        if (minNumberEven > num) { minNumberEven = num; }
                        if (maxNumberEven < num) { maxNumberEven = num; }
                    }
                        
                }

                /* odd-position numbers */
                else
                {
                    sumOdd += num;

                    /*first odd-position number*/
                    if (i == 1) { minNumberOdd = num; maxNumberOdd = num; }
                    else
                    {
                        if (minNumberOdd > num) { minNumberOdd = num; }
                        if (maxNumberOdd < num) { maxNumberOdd = num; }
                    }
                }

            }

            /* output */
            Console.WriteLine("OddSum=" + sumOdd);
            if (n == 0)
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
            }

            else
            {
                Console.WriteLine("OddMin=" + minNumberOdd);
                Console.WriteLine("OddMax=" + maxNumberOdd);
            }

            Console.WriteLine("EvenSum=" + sumEven);
            if (n <= 1)
            {
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }

            else
            {
                Console.WriteLine("EvenMin=" + minNumberEven);
                Console.WriteLine("EvenMax=" + maxNumberEven);
            }
        }
    }
}
