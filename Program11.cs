using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program11
    {
        static void Main()
        {
            int i = 49 ;
            
            i = Convert.ToInt32(Console.ReadLine());
            for (i = 100; i <= 200; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine("No. divisible by 7 in between 200 and 300 ", i);
                Console.ReadKey();
            }
        }
    }
}
