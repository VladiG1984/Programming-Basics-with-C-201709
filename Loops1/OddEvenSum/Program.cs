﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0) { sumEven = sumEven + num; }
                else { sumOdd = sumOdd + num; }
            }

            if (sumEven == sumOdd) { Console.WriteLine("Yes");
                                     Console.WriteLine("Sum = " + sumEven); }
            else { Console.WriteLine("No"); Console.WriteLine("Diff = " + Math.Abs(sumEven - sumOdd)); }
        }
    }
}
