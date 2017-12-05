using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0to100toText
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var decimals = "";
            var unit = "";

            if (num == 0)
            {
                unit = "zero";
            }

            switch(num % 10)
            {
                case 1: unit = "one"; break;
                case 2: unit = "two"; break;
                case 3: unit = "three"; break;
                case 4: unit = "four"; break;
                case 5: unit = "five"; break;
                case 6: unit = "six"; break;
                case 7: unit = "seven"; break;
                case 8: unit = "eight"; break;
                case 9: unit = "nine"; break;
                                    
            }
            

            if (num >= 10 && num < 20)

            {
                switch (num % 10)
                {
                    case 0: unit = "ten"; break;
                    case 1: unit = "eleven"; break;
                    case 2: unit = "twelve"; break;
                    case 3: unit = "thirteen"; break;
                    case 4: unit = "forteen"; break;
                    case 5: unit = "fifteen"; break;
                    case 6: unit = "sixteen"; break;
                    case 7: unit = "seventeen"; break;
                    case 8: unit = "eighteen"; break;
                    case 9: unit = "nineteen"; break;
                    
                }
            }

            if (num >=20 && num <= 100)
            {
                switch(num / 10)
                {
                    case 2: decimals = "twenty"; break;
                    case 3: decimals = "thirty"; break;
                    case 4: decimals = "forty"; break;
                    case 5: decimals = "fifty"; break;
                    case 6: decimals = "sixty"; break;
                    case 7: decimals = "seventy"; break;
                    case 8: decimals = "eighty"; break;
                    case 9: decimals = "ninety"; break;
                    case 10: decimals = "one hundred"; break;
                    
                }
            }

            if (num >=0 & num <=100)
            {
                if (decimals == "")
                {
                    Console.WriteLine(unit);
                }

                else if (unit == "")
                {
                    Console.WriteLine(decimals);
                }

                else
                {
                    Console.WriteLine("{0} {1}", decimals, unit);
                }
            }            
            
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
