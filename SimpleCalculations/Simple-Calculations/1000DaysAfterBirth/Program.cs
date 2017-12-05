using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            var format = "dd-MM-yyyy";

            var BirthdayStr = Console.ReadLine();
            
            var Birthday = DateTime.ParseExact(BirthdayStr, format, provider);

            var Birthday_add1000 = Birthday.AddDays(1000);
            

            Console.WriteLine(Birthday_add1000.ToString(format));
            
        }
    }
}
