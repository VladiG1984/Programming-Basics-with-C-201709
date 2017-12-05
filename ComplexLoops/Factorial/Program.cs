using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = n;
            int num = n;

            while (b != 1)
            {
                num = num * (b - 1);
                b = b - 1;
            }

            Console.WriteLine(num);
        }
    }
}
