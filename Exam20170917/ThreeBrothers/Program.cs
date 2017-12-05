using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal timeB1 = decimal.Parse(Console.ReadLine());
            decimal timeB2 = decimal.Parse(Console.ReadLine());
            decimal timeB3 = decimal.Parse(Console.ReadLine());
            decimal timeF = decimal.Parse(Console.ReadLine());

            decimal totalCleaningTime = (1 / (1 / timeB1 + 1 / timeB2 + 1 / timeB3)) * 1.15m;

            Console.WriteLine("Cleaning time: {0:f2}", totalCleaningTime);

            if (totalCleaningTime < timeF)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", 
                            Math.Floor(timeF - totalCleaningTime));

            }

            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.",
                            Math.Ceiling(totalCleaningTime - timeF));
            }
        }
    }
}
