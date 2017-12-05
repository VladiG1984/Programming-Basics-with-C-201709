using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var exchange_rate = 1.79549;

            var BGN = Math.Round(USD * exchange_rate, 2);

            Console.WriteLine(BGN);
        }
    }
}
