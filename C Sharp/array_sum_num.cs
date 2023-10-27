using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sum_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {2,5,8};
            int sum = 0;


            Console.Write("Find sum of all elements of array:");
            Console.WriteLine();

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}
    }
}
nt[] arr = new int[] { 1, 2, 3 };
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}