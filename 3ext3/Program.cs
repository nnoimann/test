using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ext3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of matrix elements");
            int n = int.Parse(Console.ReadLine());
            int s = n;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} element", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            string massiv = string.Join(",", arr);
            int[] arr2 = arr;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr2[j] > arr2[j + 1])
                    {
                        temp = arr2[j];
                        arr2[j] = arr2[j + 1];
                        arr2[j + 1] = temp;
                    }
                }
            }
            string massiv2 = string.Join(",", arr2);
            Console.WriteLine("This is a sorted array: " + massiv2);
            Console.WriteLine("This is not a sorted array: " + massiv);
        }
    }
}
