using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_decending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int temp;
            Console.WriteLine("enter no :");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr1[i] <= arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.WriteLine("decending order :");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", arr1[i]);

            }
            Console.ReadKey();
        }
    }
}

   