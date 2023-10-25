using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_parameter_table
{
    class Program
    {
        static void table(int num)

        {

            int result = 0;

            for (int cnt = 1; cnt <= 10; cnt++)
            {
                result = num * cnt;
                Console.WriteLine(result);
            }


        }

                static void Main (string[] args)


                {

                    table(4);
                    Console.ReadKey();
                }
            }
        }
    



                



                    