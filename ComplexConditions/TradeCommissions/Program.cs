using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commission = -1.0;
            var errorMsg = "";

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500) { commission = 0.05; }
                else if (sales > 500 && sales <= 1000) { commission = 0.07; }
                else if (sales > 1000 && sales <= 10000) { commission = 0.08; }
                else if (sales > 10000) { commission = 0.12; }
                else errorMsg = "error";
            }

            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500) { commission = 0.045; }
                else if (sales > 500 && sales <= 1000) { commission = 0.075; }
                else if (sales > 1000 && sales <= 10000) { commission = 0.10; }
                else if (sales > 10000) { commission = 0.13; }
                else errorMsg = "error";
            }

            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) { commission = 0.055; }
                else if (sales > 500 && sales <= 1000) { commission = 0.08; }
                else if (sales > 1000 && sales <= 10000) { commission = 0.12; }
                else if (sales > 10000) { commission = 0.145; }
                else errorMsg = "error";
            }

            else errorMsg = "error";

            if (errorMsg != "error") { Console.WriteLine(Math.Round(sales * commission, 2)); }
            else { Console.WriteLine("error"); }
        }
    }
}
