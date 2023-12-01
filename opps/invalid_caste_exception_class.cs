using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalid_caste_exception_class
{
    internal class Program
    {
        class program
        {

        
        static void Main(string[] args)
        {
                StringBuilder sb = new StringBuilder();
                sb.Append("ravi");
                sb.Append("amit");
                Console.WriteLine("sb:"+sb.ToString());
                object obj = sb;
                Console.WriteLine  ("obj:" + obj.ToString());

                 try
                {
                    System.IO.StreamReader sr = (System.IO.StreamReader)obj;
                }
                catch (InvalidCastException ee)
                {
                    Console.WriteLine(ee.ToString());
                }
                Console.WriteLine("bye");
                Console.ReadKey();
            }
         
               
            }


        }
    }

