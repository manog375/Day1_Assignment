using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayAssignment
{
    class Program18
    { public static int Total(List<int> markList)
        {
            int total = 0;
            foreach(int result in markList)
            {
                total = +result;
            }
            return total;
        }
        public static void Main()
        {
            Console.WriteLine("enter 10 marks");
            List<int> markList = new List<int>();
            for(int index =0; index<10; index++)
            {
                markList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Total is" + Total(markList)); 
            Console.WriteLine("average is " + Total(markList) / 10);
            markList.Sort();
            Console.WriteLine(markList[0] + " .inimum marks");
            //Console.WriteLine(markList[markList.Count-1] + " minimum marks");
            Console.WriteLine(" marks ascending order");
            foreach(int result in markList)
            {
                Console.Write(result + " ");
                   
            }
            markList.Reverse();
            Console.WriteLine("  descending marks ");
            foreach (int result in markList)
            {
                Console.Write(result + " ");

            }
            Console.ReadKey();
        }
    }
}
