using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal parcelWeightKg = decimal.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine().ToLower();
            int distanceKm = int.Parse(Console.ReadLine());

            decimal pricePerKm = 0.0m;
            decimal priceAdditionalPerKm = 0.0m;

            if (parcelWeightKg < 1) { pricePerKm = 0.03m; }
            else if (parcelWeightKg <= 10) { pricePerKm = 0.05m; }
            else if (parcelWeightKg <= 40) { pricePerKm = 0.1m; }
            else if (parcelWeightKg <= 90) { pricePerKm = 0.15m; }
            else if (parcelWeightKg <= 150) { pricePerKm = 0.20m; }

            if (serviceType == "express")
            {
                if (parcelWeightKg < 1) { priceAdditionalPerKm = 0.03m * 0.8m * parcelWeightKg; }
                else if (parcelWeightKg <= 10) { priceAdditionalPerKm = 0.05m * 0.4m * parcelWeightKg; }
                else if (parcelWeightKg <= 40) { priceAdditionalPerKm = 0.1m * 0.05m * parcelWeightKg; }
                else if (parcelWeightKg <= 90) { priceAdditionalPerKm = 0.15m * 0.02m * parcelWeightKg; }
                else if (parcelWeightKg <= 150) { priceAdditionalPerKm = 0.20m * 0.01m * parcelWeightKg; }
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.",
                parcelWeightKg, (pricePerKm + priceAdditionalPerKm)* distanceKm);
            
        }
    }
}
