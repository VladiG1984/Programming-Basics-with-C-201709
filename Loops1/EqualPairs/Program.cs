using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumPrev = 0;
            double sumCurrent = 0;
            double diffCurrentPrev = 0;
            int count = 1;

            for (int i = 1; i <= 2 * n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (count <= 2)
                {
                    sumCurrent += num;

                    if (count == 2)
                    {
                        if (i > 2) { diffCurrentPrev = Math.Max(Math.Abs(sumCurrent - sumPrev), diffCurrentPrev); }
                        sumPrev = sumCurrent; sumCurrent = 0; count = 0;
                    }

                    count += 1;
                }

            }

            if (diffCurrentPrev == 0)
            {
                Console.WriteLine("Yes, value=" + sumPrev);
            }

            else { Console.WriteLine("No, maxdiff=" + diffCurrentPrev); }
        }
    }
}
