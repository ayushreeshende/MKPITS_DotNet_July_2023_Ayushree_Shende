using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 =new int[3] ;
            int cnt = 0;
            
           
             for(int  i = 0; i < 3; i++)
            {
              Console.WriteLine("enter nunbers :");
                arr1[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element:{0}-{1}", i, arr1[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {

                        if (arr1[i] == arr1[j])
                        {
                            cnt++;
                            break;

                        }

                    }
                }

                if (cnt == 0)
                {
                    Console.WriteLine("unique element:" + arr1[i]);
                }
            }
                Console.ReadKey();
            
        }
    }
   }

