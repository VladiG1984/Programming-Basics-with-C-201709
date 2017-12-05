using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            decimal percOccuppied = decimal.Parse(Console.ReadLine());

            decimal volume = (length * width * height) * (1 - percOccuppied * 0.01m) * 0.001m;

            Console.WriteLine("{0:f3}", volume);
        }
    }
}
