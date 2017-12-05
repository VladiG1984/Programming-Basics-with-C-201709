using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            if (Math.Min(Math.Min(num1, num2), num3) == Math.Max(Math.Max(num1, num2), num3))
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
