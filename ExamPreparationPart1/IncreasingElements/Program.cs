using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sequenceLength = 0;
            int sequenceLengthMax = 0;

            int a_old = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a > a_old)
                {
                    sequenceLength += 1;
                }

                else
                {
                    sequenceLength = 1;
                }

                if (sequenceLength > sequenceLengthMax)
                { 
                    sequenceLengthMax = sequenceLength;
                }

                a_old = a;
            }
            Console.WriteLine(sequenceLengthMax);
        }
    }
}
