using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed1 = int.Parse(Console.ReadLine());
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            
            decimal speed2 = speed1 * 1.1m; // m signifies that 1.1 is in decimal format
            decimal speed3 = speed2 * 0.95m;

            decimal distance = Math.Round((time1 / 60m) * speed1 + (time2 / 60m) * speed2 +
                                (time3 / 60m) * speed3, 2);

            Console.WriteLine("{0:f2}", distance); // always give 2 decimal places after the decimal point
        }
    }
}
