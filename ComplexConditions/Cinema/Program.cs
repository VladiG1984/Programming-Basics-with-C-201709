using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProjType = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());

            switch (ProjType)
            {
                case "premiere": Console.WriteLine(Math.Round(row * column * 12.00, 2)); break;
                case "normal": Console.WriteLine(Math.Round(row * column * 7.50, 2)); break;
                case "discount": Console.WriteLine(Math.Round(row * column * 5.00, 2)); break;

            }
        }
    }
}
