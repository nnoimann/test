using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string number_one = Console.ReadLine();
            int number_string = Convert.ToInt32(number_one);
            Console.WriteLine(number_one, number_string.GetType());
        }
    }
}
