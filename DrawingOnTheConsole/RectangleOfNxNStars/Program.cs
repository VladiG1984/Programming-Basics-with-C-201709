using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (var i = 1; i <= num; i++)
            {
                Console.WriteLine(new string('*', num));
            }
        }
    }
}
