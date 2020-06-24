using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program2
    {
        public static void Main(string[] args)
        {
            int a = Int32.Parse(args[0]);
            int b = Int32.Parse(args[1]);
            for (int i =a;i<b; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
        
    }

}
