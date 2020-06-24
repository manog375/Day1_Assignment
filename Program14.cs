using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program14
    {
        static void Main(String[] args)
        {
            string str; 
            int l = 0;

            Console.Write("Find the length of a string :");
            
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the string is : {0}", l);
            Console.ReadKey();
           
        }
         
    }



}
