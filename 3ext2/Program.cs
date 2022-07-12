using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ext2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of matrix elements");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} element", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            int index = -1;
            for (int i = 0; i < arr.Length; ++i)
            {
                int k = 1;
                for (int j = i + 1; j < arr.Length; ++j)
                    if (arr[i] == arr[j]) k++;
                if (k <= count) continue;
                count = k;
                index = i;
            }
            Console.WriteLine("a[{0}]={1} Repeated {2} times", index, arr[index], count);
            Console.ReadKey();
        }
    }
}
