using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {   
        public void pluss(int num_first, int num_second)
        {
            Console.WriteLine("Result: " + (num_first + num_second));
        }
        public void subtraction(int num_first, int num_second)
        {
            Console.WriteLine("Result: " + (num_first - num_second));
        }
        public void multiplication(int num_first, int num_second)
        {
            Console.WriteLine("Result: " + (num_first * num_second));
        }
        public void division(int num_first, int num_second)
        {
            Console.WriteLine("Result: " + (num_first / num_second));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num_first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num_second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation(/, +, -, *): ");
            string operation = Console.ReadLine();
            var AdditionOperation = new Program();
            var SubtractionOperation = new Program();
            var MultiplicationOperation = new Program();
            var DivisionOperation = new Program();
            if (operation == "+")
            {
                AdditionOperation.pluss(num_first, num_second);
            } else if(operation == "-")
            {
                SubtractionOperation.subtraction(num_first, num_second);
            }
            else if (operation == "*")
            {
                MultiplicationOperation.multiplication(num_first, num_second);
            }
            else if (operation == "/")
            {
                DivisionOperation.division(num_first, num_second);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }
}
