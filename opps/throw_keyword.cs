using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace throw_keyword
{
    internal class Program
    {
        class program
        {

        
        static void Main(string[] args)
        {
                int age = 0;
                try
                {
                    Console.WriteLine("enter age");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age < 18)
                    {
                        throw new Exception("age should be greater or equal to 18");
                    }
                    else
                            
                    {
                        throw new Exception("age{0}"+age);
                    }

                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                    Console.WriteLine("enter age 18 or greater than 18");
                    age = Convert.ToInt32(Console.ReadLine());
                }
                finally
                {
                    Console.WriteLine("block is executing");
                    Console.WriteLine("age:" + age);
                }
                    Console.WriteLine("bye");
                Console.ReadKey();
                }
            
            


            }
        }
}
