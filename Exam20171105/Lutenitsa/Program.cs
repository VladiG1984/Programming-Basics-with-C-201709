using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tomatoes = decimal.Parse(Console.ReadLine());
            int cassettesPerTruck = int.Parse(Console.ReadLine());
            int jarsPerCassette = int.Parse(Console.ReadLine());

            decimal lutenitsa = tomatoes / 5;
            decimal jarsFilled = lutenitsa / 0.535m;
            decimal cassettesFilled = jarsFilled / jarsPerCassette;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenitsa));

            if (cassettesFilled >= cassettesPerTruck)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(cassettesFilled - cassettesPerTruck));
                Console.WriteLine("{0} jars left.", Math.Floor(jarsFilled - jarsPerCassette * cassettesPerTruck));
            }

            else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(cassettesPerTruck - cassettesFilled));
                Console.WriteLine("{0} more jars needed.", Math.Floor(cassettesPerTruck * jarsPerCassette - jarsFilled));
            }

        }
    }
}
