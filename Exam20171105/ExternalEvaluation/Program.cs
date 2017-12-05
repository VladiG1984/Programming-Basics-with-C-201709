using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());

            decimal poorMarks = 0.0m;
            decimal satisfactoryMarks = 0.0m;
            decimal goodMarks = 0.0m;
            decimal veryGoodMarks = 0.0m;
            decimal excellentMarks = 0.0m;

            for (int i = 1; i <= numberStudents; i++)
            {
                decimal markStudent = decimal.Parse(Console.ReadLine());

                if (markStudent >=0m && markStudent < 22.5m)
                {
                    poorMarks++;
                }

                else if (markStudent < 40.5m)
                {
                    satisfactoryMarks++;
                }

                else if (markStudent < 58.5m)
                {
                    goodMarks++;
                }

                else if (markStudent < 76.6m)
                {
                    veryGoodMarks++;
                }

                else if (markStudent <= 100m)
                {
                    excellentMarks++;
                }

            }

            Console.WriteLine("{0:f2}% poor marks", poorMarks / numberStudents * 100);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactoryMarks / numberStudents * 100);
            Console.WriteLine("{0:f2}% good marks", goodMarks / numberStudents * 100);
            Console.WriteLine("{0:f2}% very good marks", veryGoodMarks / numberStudents * 100);
            Console.WriteLine("{0:f2}% excellent marks", excellentMarks / numberStudents * 100);
        }
    }
}
