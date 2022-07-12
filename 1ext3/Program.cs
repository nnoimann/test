using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ext3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("An exception occurred");
            }
            finally
            {
                Console.WriteLine("Program completed");
            }
        }
    }
}
