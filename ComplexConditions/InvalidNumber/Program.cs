using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            var InRange = (num >= 100 && num <= 200) || num == 0;

            if (!InRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
