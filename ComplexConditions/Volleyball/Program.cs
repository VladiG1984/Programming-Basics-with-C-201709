using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();

            /*number of holidays in year that are not weekends*/
            int holidays = int.Parse(Console.ReadLine());

            /*number of weekends spent in hometown*/
            int weekendsHome = int.Parse(Console.ReadLine());

            int SofiaWeekends = 48 - weekendsHome;
            double playSofia = 2.0 * holidays / 3.0 + 3.0 * SofiaWeekends / 4.0;
            double playTotal = playSofia + weekendsHome;

            if (year.Equals("leap"))
            {
                playTotal = Math.Floor(playTotal * 1.15);
            }

            else if (year.Equals("normal"))
            { 
                    playTotal = Math.Floor(playTotal);
            }

            Console.WriteLine(playTotal);

        }
    }
}
