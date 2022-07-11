using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ext3
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
            int D = ((num_second * num_second) - (4 * num_first * num_third));
            int x1;
            int x2;
            if (D > 0)
            {
                x1 = Convert.ToInt32((-(num_second) + Math.Sqrt(D)) / (2 * num_first));
                x2 = Convert.ToInt32((-(num_second) - Math.Sqrt(D)) / (2 * num_first));
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            } else if(D == 0)
            {
                x1 = x2 = ((-num_second) / (2 * num_first));
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("The numbers will be complex");
            }
        }
    }
}
