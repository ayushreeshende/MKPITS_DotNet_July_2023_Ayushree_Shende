using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_value
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                
                int[] num= new int[5]; // 5 size array

                // Accepting value from user 
                for (i = 0; i < 5; i++)
                {
                    Console.Write("\nEnter your number:\t");
                    //Storing value in an array
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n\n");
                //Printing the value on console
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("num [{0}]={1}", i, num[i]);
                        
                }
                Console.ReadKey();
            }
        }
    }
}

