using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_with_different_types_of_parameter
{
    class calculate
    {
        public void addition(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("addition of 2 int is" + res);
        }
        public void addition(float n1, float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("addition of 2 float is" + res);
        }
        class program
        {


            static void Main(string[] args)
            {
                calculate c = new calculate();
                c.addition(2, 3);
                Console.WriteLine("new calling addition of float no");
                c.addition(2.3f, 3.3f);
                Console.ReadKey();
            }
        }
    }
    }
