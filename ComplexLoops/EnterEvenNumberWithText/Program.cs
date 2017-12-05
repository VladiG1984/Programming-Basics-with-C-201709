using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumberWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter even number: ");
                int n = int.Parse(Console.ReadLine());

                while (n % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("Even number entered: {0}", n);
            }

            catch
            {
                Console.WriteLine("Invalid number.");

                Console.WriteLine("Enter even number: ");
                int n = int.Parse(Console.ReadLine());

                while (n % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("Even number entered: {0}", n);
            }
            
        }
    }
}
