using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            decimal chrysanthemumsPrice = 2m;
            decimal rosesPrice = 4.1m;
            decimal tulipsPrice = 2.5m;
            

            if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumsPrice = 3.75m;
                rosesPrice = 4.5m;
                tulipsPrice = 4.15m;
            }

            if (holiday == "Y")
            {
                chrysanthemumsPrice = 1.15m * chrysanthemumsPrice;
                rosesPrice = 1.15m * rosesPrice;
                tulipsPrice = 1.15m * tulipsPrice;
            }

            decimal bouquetPrice = chrysanthemums * chrysanthemumsPrice + roses * rosesPrice +
                                    tulips * tulipsPrice;

            if (tulips >= 7 && season == "Spring")
            {
                bouquetPrice = 0.95m * bouquetPrice;
            }

            if (roses >= 10 && season == "Winter")
            {
                bouquetPrice = 0.9m * bouquetPrice;
            }

            if (chrysanthemums + roses + tulips >= 20)
            {
                bouquetPrice = 0.8m * bouquetPrice;
            }

            // add bouquet arrangement fee
            bouquetPrice = bouquetPrice + 2;

            Console.WriteLine("{0:f2}", bouquetPrice);
        }
    }
}
