using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program12
    {
        static void Main()
        {
            int n1, n2, n3;
            Console.Write("Input the 1st number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.Write("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. ");
                }
            }
            else if (n2 > n3)
                Console.Write("The 2nd Number is the greatest among three .");
            else
                Console.Write("The 3rd Number is the greatest among three .");
            Console.ReadKey();
        }

    
    }
        
}
