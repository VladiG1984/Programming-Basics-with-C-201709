using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int area = 0;
            int count = 0;

            for (int x1 = -n; x1 <= n; x1++)
            {
                for (int y1 = -n; y1 <= n; y1++)
                {
                    for (int x2 = n; x2 > x1; x2--)
                    {
                        for (int y2 = n; y2 > y1; y2--)
                        {
                            area = (x2 - x1) * (y2 - y1);

                            if (area >= m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", x1, y1, x2, y2, area);
                                count++;
                            }

                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
