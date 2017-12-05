using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string a = "*";
            string b = "";
            string c = "";
            string d = "";


            for (int i = 1; i <= n; i++)
            {
                if (i == 1) for (int j = 1; j <= n; j++) { b = a + b; if (j == n) Console.WriteLine(b); }
                else if (i < n) for (int k = 1; k <= n-2; k++)
                    {
                        d = " " + d;
                        if (k == n-2) { d = a + d + a; Console.WriteLine(d); d = ""; }


                    }
                else if (i == n) for (int j = 1; j <= n; j++) { c = a + c; if (j == n) Console.WriteLine(c); }
                    
            }
        }
    }
}
