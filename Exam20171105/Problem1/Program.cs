using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal priceMeter = decimal.Parse(Console.ReadLine());
            decimal weightMeterSq = decimal.Parse(Console.ReadLine());

            int lengthNet = (length + width) * 2;
            decimal priceNet = lengthNet * priceMeter;
            decimal weightNet = weightMeterSq * lengthNet * height;

            Console.WriteLine(lengthNet);
            Console.WriteLine("{0:f2}", priceNet);
            Console.WriteLine("{0:f3}", weightNet);
        }
    }
}
