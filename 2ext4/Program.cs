using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ext4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num_first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num_second = Convert.ToInt32(Console.ReadLine());
            int Quotient_of_division = num_first % num_second;
            int Result = num_first / num_second;
            if (Quotient_of_division == 0)
            {
                Console.WriteLine("The number to divide without a remainder");
                Console.WriteLine("Result " + Result);
            } else if(Quotient_of_division != 0)
            {
                Console.WriteLine("The number is divisible with the remainder");
                Console.WriteLine("Result" + Result);
                Console.WriteLine("Quotient of division " + Quotient_of_division);
            } else if (num_second == 0)
            {
                Console.WriteLine("Infinity");
            }
        }
    }
}
