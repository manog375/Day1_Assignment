using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program8
    {
        static void Main()
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("enter number");
            count = Int16.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
    }


}
