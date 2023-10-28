using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter number:");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0; int k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.Write("Even no:");
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);

            }
            Console.Write("\nOdd no:");
            for (int i=0;i<k;i++)
            {
                Console.Write("{0} ", arr3[i]);

            }
            Console.ReadKey();
            }
        }
    }

