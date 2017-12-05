using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double workMoney = double.Parse(Console.ReadLine());

            double area = floorWidth * floorLength;
            double tileArea = tileSide * tileHeight / 2;
            double tileNumber = Math.Ceiling(area / tileArea) + 5;
            double tileMoney = tileNumber * tilePrice;
            double totalMoney = tileMoney + workMoney;

            double diffMoney = money - totalMoney;

            if (diffMoney >= 0)
            {
                Console.WriteLine("{0:f2} lv left.", diffMoney);
            }

            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(diffMoney));
            }
        }
    }
}
