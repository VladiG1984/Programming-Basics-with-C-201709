using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && x < 3 * h && y > 0 && y < h) /* inside horizontal squares*/
            {
                Console.WriteLine("inside");
            }

            else if (x > 1 * h && x < 2 * h && y >= 1 * h && y < 4 * h) /*inside vertical squares*/
            {
                Console.WriteLine("inside");
            }

            else if (y == 0 && x >= 0 && x <= 3 * h) /*on lower horizontal border*/
            {
                Console.WriteLine("border");
            }

            else if ((y == 1 * h) && ((x >= 0 && x <= 1 * h) ||
                      (x >= 2 * h && x <= 3 * h))) /*on middle horizontal border*/
            {
                Console.WriteLine("border");
            }

            else if (y == 4 * h && x >= 1 * h && x <= 2 * h) /*on upper horizontal border*/
            {
                Console.WriteLine("border");
            }

            else if ((x == 0 || x == 3 * h) && (y >= 0 && y <= 1 * h)) /*on outer left/ right borders*/
            {
                Console.WriteLine("border");
            }

            else if ((x == 1 * h || x == 2 * h) && (y >=1 * h && y <= 4 * h)) /*on inner left/ right borders*/
            {
                Console.WriteLine("border");
            }
            
            else { Console.WriteLine("outside"); }
        }
    }
}
