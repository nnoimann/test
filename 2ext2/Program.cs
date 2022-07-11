using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ext2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num_first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num_second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int num_third = Convert.ToInt32(Console.ReadLine());
            int[] numbers = { num_first, num_second, num_third };
            var orderedNumbers = from i in numbers
                                 orderby i
                                 select i;
            Console.WriteLine("Numbers in ascending order");
            foreach (int i in orderedNumbers)
                Console.WriteLine(i);
            if ((num_first > num_second) && (num_first < num_third))
            {
                Console.Write("Average:", num_first);
            }
            if ((num_first > num_third) && (num_first < num_second))
            {
                Console.Write("Average:", num_first);
            }
            if ((num_second > num_first) && (num_second < num_third))
                Console.Write("Average:", num_second);
            if ((num_second > num_third) && (num_second < num_first))
                Console.Write("Average:", num_second);
            if ((num_third > num_second) && (num_third < num_first))
                Console.Write("Average:", num_third);
            if ((num_third > num_first) && (num_third < num_second))
                Console.Write("Average:", num_third);
        }
    }
}
