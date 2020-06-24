using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program10
    {
        static void Main()
        {
            int p, n;
            Console.WriteLine("table calculated");
            n = Convert.ToInt32(Console.ReadLine());

            for (p = 1; p <= 10; p++)
            {
                Console.Write("{0} X {1} = {2} ", n, p, n * p);
               
             }
            Console.ReadKey();
        }
    }
}


