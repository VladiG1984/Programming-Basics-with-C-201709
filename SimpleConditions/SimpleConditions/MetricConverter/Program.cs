using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num_in = double.Parse(Console.ReadLine());
            var measure_unit_in = Console.ReadLine().ToLower();
            var measure_unit_out = Console.ReadLine().ToLower();
            var num_meter = 0.0;
            var num_out = 0.0;

/// convertion table between meter and rest of measurement units
            var m_to_mm = 1000;
            var m_to_cm = 100;
            var m_to_mi = 0.000621371192;
            var m_to_in = 39.3700787;
            var m_to_km = 0.001;
            var m_to_ft = 3.2808399;
            var m_to_yd = 1.0936133;

/// all to meters and then to respective output measurement unit

            if (measure_unit_in == "m")
            {
                num_meter = num_in;
            }
            if (measure_unit_in == "mm")
            {
                num_meter = num_in / m_to_mm;
            }

            else if (measure_unit_in == "cm")
            {
                num_meter = num_in / m_to_cm;
            }

            else if (measure_unit_in == "mi")
            {
                num_meter = num_in / m_to_mi;
            }

            else if (measure_unit_in == "in")
            {
                num_meter = num_in / m_to_in;
            }

            else if (measure_unit_in == "km")
            {
                num_meter = num_in / m_to_km;
            }

            else if (measure_unit_in == "ft")
            {
                num_meter = num_in / m_to_ft;
            }

            else if (measure_unit_in == "yd")
            {
                num_meter = num_in / m_to_yd;
            }

/// convert to output measurement unit

            if (measure_unit_out == "m")
            {
                num_out = num_meter;
            }

            else if (measure_unit_out == "mm")
            {
                num_out = num_meter * m_to_mm;
            }

            else if (measure_unit_out == "cm")
            {
                num_out = num_meter * m_to_cm;
            }

            else if (measure_unit_out == "mi")
            {
                num_out = num_meter * m_to_mi;
            }

            else if (measure_unit_out == "in")
            {
                num_out = num_meter * m_to_in;
            }

            else if (measure_unit_out == "km")
            {
                num_out = num_meter * m_to_km;
            }

            else if (measure_unit_out == "ft")
            {
                num_out = num_meter * m_to_ft;
            }

            else if (measure_unit_out == "yd")
            {
                num_out = num_meter * m_to_yd;
            }

            else
            {
                Console.WriteLine("Not such combination is available!");
            }

            Console.WriteLine(num_out);
        }
    }
}
