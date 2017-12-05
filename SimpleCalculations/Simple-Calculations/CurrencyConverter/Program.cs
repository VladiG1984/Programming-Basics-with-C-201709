using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry_amount = double.Parse(Console.ReadLine());
            var entry_currency = Console.ReadLine();
            var exit_currency = Console.ReadLine();

            var USD_to_BGN_rate = 1.79549;
            var EUR_to_BGN_rate = 1.95583;
            var GBP_to_BGN_rate = 2.53405;
            
            if (exit_currency == "BGN")
            {
                if (entry_currency == "USD") { var exit_amount = Math.Round(entry_amount * USD_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "EUR") { var exit_amount = Math.Round(entry_amount * EUR_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "GBP") { var exit_amount = Math.Round(entry_amount * GBP_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
            }

            else if (exit_currency == "USD")
            {
                if (entry_currency == "BGN") { var exit_amount = Math.Round(entry_amount / USD_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "EUR") { var exit_amount = Math.Round((entry_amount / USD_to_BGN_rate) * EUR_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "GBP") { var exit_amount = Math.Round((entry_amount / USD_to_BGN_rate) * GBP_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
            }

            else if (exit_currency == "EUR")
            {
                if (entry_currency == "USD") { var exit_amount = Math.Round((entry_amount / EUR_to_BGN_rate) * USD_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "BGN") { var exit_amount = Math.Round(entry_amount / EUR_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "GBP") { var exit_amount = Math.Round((entry_amount / EUR_to_BGN_rate) * GBP_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
            }

            else if (exit_currency == "GBP")
            {
                if (entry_currency == "USD") { var exit_amount = Math.Round((entry_amount / GBP_to_BGN_rate) * USD_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "EUR") { var exit_amount = Math.Round((entry_amount / GBP_to_BGN_rate) * EUR_to_BGN_rate, 2); Console.WriteLine(exit_amount); }
                else if (entry_currency == "BGN") { var exit_amount = Math.Round(entry_amount / GBP_to_BGN_rate, 2); Console.WriteLine(exit_amount); }

            }

            
        }
    }
}
