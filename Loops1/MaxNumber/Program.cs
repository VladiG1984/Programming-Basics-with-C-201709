using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i == 1) { maxNumber = num; }
                else if (maxNumber < num) { maxNumber = num; }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
