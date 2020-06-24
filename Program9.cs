using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program9
    {
        static void Main()
        {
            Console.WriteLine("integer number");
            int Value = 5;
            long sum = 0;
            int  number = Convert.ToInt32(Console.ReadLine());
           if(number < Value)
            {
                int temp = number;
                number = Value;
                Value = temp;

            }
           for(int index =Value;index <=number;index++)
            {
                sum += index * index * index;

            }
            Console.WriteLine(sum);
            Console.ReadKey();
            }
        }
    }

