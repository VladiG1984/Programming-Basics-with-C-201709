using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonus_score = 0.0;
            var total_score = 0.0;

            if (num <= 100)
            {
                bonus_score = 5;
            }

            if (num > 100)
            {
                bonus_score = 0.20 * num;
            }

            if (num > 1000)
            {
                bonus_score = 0.10 * num;
            }

            if (num % 2 == 0)
            {
                bonus_score = bonus_score + 1;
            }

            if (num % 2 != 0)
            {
                if (num % 5 == 0)

                {
                    bonus_score = bonus_score + 2;
                }
            }

            total_score = num + bonus_score;

            Console.WriteLine(bonus_score);
            Console.WriteLine(total_score);
        }
    }
}
