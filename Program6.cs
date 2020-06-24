using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program6
    {
        static void Main(String [] args)
        {
            int i,n,sum=0;
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The  square number  upto {0} terms :", n);
            for (i = 0; i <= n; i++)
            {
                Console.Write("{0}  ", i * i);
                sum += i * i;
            }
            Console.Write("The Sum of square  Number upto {0} terms = {0} ", n, sum);

        }
    }
}
