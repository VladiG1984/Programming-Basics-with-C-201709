using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double point = double.Parse(Console.ReadLine());

            double first = Math.Min(x1, x2);
            double second = Math.Max(x1, x2);

            double distance = Math.Min(Math.Abs(point - first), Math.Abs(point - second));

            if (first <= point && point <= second)
            {
                Console.WriteLine("in");
            }

            else
            {
                Console.WriteLine("out");
            }

            Console.WriteLine(distance);
        }
    }
}
