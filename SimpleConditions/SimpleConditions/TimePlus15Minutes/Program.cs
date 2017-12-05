using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            
            var hour_plus15 = (hour * 60 + min + 15) / 60;
            var min_plus15 = (min + 15) % 60;

            if (hour_plus15 >= 24)
            {
                hour_plus15 = 0;
            }

            if (min_plus15 < 10)
            {
                Console.WriteLine("{0}:0{1}", hour_plus15, min_plus15);
            }

            else
            {
                Console.WriteLine("{0}:{1}", hour_plus15, min_plus15);
            }
        }
    }
}
