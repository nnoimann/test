using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ext5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side of the triangle:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second side of the triangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third side of the triangle");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b <= c | a + c <= b | c + b <= a)
            {
                Console.WriteLine("The triangle doesn't exist");
            }
            else
            {
                if (a == b & a == c & b == c)
                {
                    Console.WriteLine("Triangle is equilateral");
                }
                else if (a == b | a == c | c == b)
                {
                    Console.WriteLine("Triangle isosceles");
                }
            }
        }
    }
}
