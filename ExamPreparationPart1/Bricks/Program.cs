using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cartLoad = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)bricks / (workers * cartLoad));

            Console.WriteLine(courses);
        }
    }
}
