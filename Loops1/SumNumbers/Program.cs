using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;

            for (int i = 1; i <= n; i++)
            {
                int j = int.Parse(Console.ReadLine());

                k = k + j;
            }

            Console.WriteLine(k);
        }
    }
}
