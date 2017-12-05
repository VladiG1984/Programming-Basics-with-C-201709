using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            var area = 0.0;

            if (shape == "square" | shape == "circle")
            {
                var param = double.Parse(Console.ReadLine());

                if (shape == "square")
                {
                    area = param * param;
                }

                else if (shape == "circle")
                {
                    area = Math.PI * param * param;
                }
            }

            else if (shape == "rectangle" | shape == "triangle")
            {
                var param1 = double.Parse(Console.ReadLine());
                var param2 = double.Parse(Console.ReadLine());

                if (shape == "rectangle")
                {
                    area = param1 * param2;
                }

                else if (shape == "triangle")
                {
                    area = param1 * param2 / 2;
                }
            }

            Console.WriteLine(area);
        }
    }
}
