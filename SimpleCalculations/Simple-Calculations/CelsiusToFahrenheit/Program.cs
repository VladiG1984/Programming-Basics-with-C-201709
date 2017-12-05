using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var Celsius = double.Parse(Console.ReadLine());
            var Fahrenheit = Math.Round(Celsius * 1.8 + 32, 2);
            Console.WriteLine(Fahrenheit);
        }
    }
}
