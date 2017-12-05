using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            decimal totalLiters = 0m;
            decimal totalDegrees = 0m;
            decimal litersNDegrees = 0m;

            for (int i = 1; i <= days; i++)
            {
                decimal liters = decimal.Parse(Console.ReadLine());
                decimal degrees = decimal.Parse(Console.ReadLine());

                totalLiters += liters;
                totalDegrees += degrees;
                litersNDegrees += liters * degrees;
            }

            decimal averageDegrees = litersNDegrees / totalLiters;
            Console.WriteLine("Liter: {0:f2}", totalLiters);
            Console.WriteLine("Degrees: {0:f2}", averageDegrees);

            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }

            else if (averageDegrees < 42)
            {
                Console.WriteLine("Super!");
            }

            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
