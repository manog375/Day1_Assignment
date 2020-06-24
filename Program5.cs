using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program5
    {
        static void Main(String[] args)
        {
            double  celsius;
            Console.WriteLine(" enter the Fahrenheit temperature");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is" + celsius);
            Console.ReadLine();
        }
    }
}
