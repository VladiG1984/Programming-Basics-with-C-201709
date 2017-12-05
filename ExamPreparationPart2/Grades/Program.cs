using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // double Grade = 0.0;

            int topStudents = 0;
            int goodStudents = 0;
            int averageStudents = 0;
            int failStudents = 0;

            double averageGrade = 0.0;
            double totalGrade = 0.0;

            int numberStudents = 0;

            double percTopStudents = 0.0;
            double percGoodStudents = 0.0;
            double percAverageStudents = 0.0;
            double percFailStudents = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double Grade = double.Parse(Console.ReadLine());

                totalGrade += Grade;
                numberStudents++;

                if (Grade >= 5.00)
                {
                    topStudents++;

                }

                else if (Grade >= 4.00)
                {
                    goodStudents++;
                }

                else if (Grade >= 3.00)
                {
                    averageStudents++;
                }

                else
                {
                    failStudents++;
                }
            }

            percTopStudents = ((double)topStudents / numberStudents) * (double)100;
            percGoodStudents = ((double)goodStudents / numberStudents) * (double)100;
            percAverageStudents = ((double)averageStudents / numberStudents) * (double)100;
            percFailStudents = ((double)failStudents / numberStudents) * (double)100;
            averageGrade = totalGrade / numberStudents;

            Console.WriteLine("Top students: {0:f2}%", percTopStudents);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", percGoodStudents);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", percAverageStudents);
            Console.WriteLine("Fail: {0:f2}%", percFailStudents);
            Console.WriteLine("Average: {0:f2}", averageGrade);
        }
    }
}
