using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers in the range from 1 to 50!");

            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var time = sec1 + sec2 + sec3;
            var minutes = time / 60;
            var seconds = 0;

            Console.WriteLine("total time: {0} & time in minutes: {1}", time, minutes);

            if (minutes == 0)
            {
                seconds = time;
            }

            if (minutes == 1)
            {
                seconds = time - 60;
            }

            if (minutes == 2)
            {
                seconds = time - 120;
            }

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }

            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }

        }
    }
}
