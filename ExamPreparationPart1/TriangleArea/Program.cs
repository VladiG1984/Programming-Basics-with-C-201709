using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            // calculate triangle base and height
            int a = Math.Abs(x2 - x3);
            int h = Math.Abs(y1 - y2);

            // calculate triangle area
            double area = (double)a * h / 2;

            Console.WriteLine(area);
        }
    }
}
