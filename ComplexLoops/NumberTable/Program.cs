using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int j = i;
                int k = 1;

                while (j <= n)
                {
                    Console.Write(j + " ");
                    
                    if (j == n)
                    {
                        if (k == n)
                        {
                            break;
                        }

                        else
                        {
                            while (j >= 1)
                            {
                                j = j - 1;
                                Console.Write(j + " ");
                                k = k + 1;

                                if (k == n)
                                {
                                    j = n; break;
                                }
                            }
                        }
                    }

                    j = j + 1;
                    k = k + 1;
                }

                Console.WriteLine();
                
            }
        }
    }
}
