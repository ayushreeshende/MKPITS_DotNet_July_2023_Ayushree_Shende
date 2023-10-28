using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {

                int[] arr1 = new int[3];
                int[] arr2 = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("enter num:");
                    arr1[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("elements of array1:");
                for (int i = 0; i < 3; i++)
                {
                    arr2[i] = arr1[i];
                    Console.WriteLine("{0}", arr1[i]);
                }
                Console.WriteLine("\nthe element copy into the second element are");
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("{0}", arr2[i]);
                }


                Console.ReadKey();
            }
        }
    }
}
