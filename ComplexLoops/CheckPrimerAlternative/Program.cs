using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrimeAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = num;
            bool IsPrime = true;

            if (num <= 1) { IsPrime = false;}

            else
            {
                while (n > 1)
                {
                    if (num % Math.Sqrt(n) == 0) { IsPrime = false; break; }
                    n = n - 1;
                }
            }
            
            if (IsPrime)
            {
                Console.WriteLine("Prime");
            }

            else
            {
                Console.WriteLine("Not prime");
            }

        }
    }
}
