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
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = Math.Round((side * height / 2), 2);
            Console.WriteLine(area);
        }
    }
}
