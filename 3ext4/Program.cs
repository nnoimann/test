using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ext4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positive_numbers = 0;
            int negative_numbers = 0;
            int zero = 0;
            int[] array = new int[20];
            Random rand = new Random();
            for (int y = 0; y < 20; y++)
            {
                array[y] = rand.Next(-10, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    positive_numbers++;
                } else if (array[i] < 0)
                {
                    negative_numbers++;
                }
                else
                {
                    zero++;
                }
            }
            string massiv = string.Join(",", array);
            Console.WriteLine(massiv);
            Console.WriteLine("Positive numbers: " + positive_numbers);
            Console.WriteLine("Negative numbers: " + negative_numbers);
            Console.WriteLine("Zero: " + zero);
        }
    }
}
