using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            
            int arr;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter no :");
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
           int max = arr1[0];
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine("\n maximum value:{0}", max);
          int  min = arr1[0];
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] < min)
                {
                    min = arr1[i];

                }

            }
            Console.WriteLine("\n minimum value:{0}", min);
            Console.ReadKey();
        }
        
    }
}

