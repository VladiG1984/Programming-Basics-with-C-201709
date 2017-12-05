using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (i == 1) { maxNumber = num; }
                else if (maxNumber < num) { maxNumber = num; }
            }

            if (maxNumber == sum - maxNumber) { Console.WriteLine("Yes");
                                                Console.WriteLine("Sum = " + maxNumber); }
            else { Console.WriteLine("No");
                   Console.WriteLine("Diff = " + Math.Abs(maxNumber - (sum - maxNumber))); }
        }
    }
}
