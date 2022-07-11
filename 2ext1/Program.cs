using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ext1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 100 != 0) & (year % 4 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else if ((year % 100 == 0) & (year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Не високосный");
            }
        }
    }
}