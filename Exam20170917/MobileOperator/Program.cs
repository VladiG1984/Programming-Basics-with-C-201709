using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string periodContract = Console.ReadLine().ToLower();
            string contractType = Console.ReadLine().ToLower();
            string internet = Console.ReadLine().ToLower();
            int months = int.Parse(Console.ReadLine());

            decimal amountContract = 0m;
            decimal discountContract = 0.0375m;
            decimal totalAmount = 0m;

            if (periodContract == "one")
            {
                switch (contractType)
                {
                    case "small": amountContract = 9.98m; break;
                    case "middle": amountContract = 18.99m; break;
                    case "large": amountContract = 25.98m; break;
                    case "extralarge": amountContract = 35.99m; break;
                }      
            }

            else if (periodContract == "two")
            {
                switch (contractType)
                {
                    case "small": amountContract = 8.58m; break;
                    case "middle": amountContract = 17.09m; break;
                    case "large": amountContract = 23.59m; break;
                    case "extralarge": amountContract = 31.79m; break;
                }
            }

            if (internet == "yes")
            {
                if (amountContract <= 10.00m) { amountContract += 5.5m; }
                else if (amountContract <= 30.00m) { amountContract += 4.35m; }
                else { amountContract += 3.85m; }
            }

            if (periodContract == "two") { totalAmount = months * amountContract * (1 - discountContract); }
            else if (periodContract == "one") { totalAmount = months * amountContract; }

            Console.WriteLine("{0:f2} lv.", totalAmount);
        }
    }
}
