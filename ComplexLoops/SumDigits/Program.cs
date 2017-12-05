using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum = sum + (n % 10); // adds remainder from dividing n by 10 to sum
                n = n / 10; // removes right-most integer from n since we divide by 10 and n is integer
            }

            while (n > 0);

            Console.WriteLine(sum);

        }
    }
}
