using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace handling_exception
{
    class DivisionNumber
        {
        int result;
        DivisionNumber()
        {
             result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {


                result = num1 / num2;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught:{0}" + e);
            }
            finally
            {
                Console.WriteLine("result:{0}", result);
            }
        }


    

  
        class program
        {

        
        static void Main(string[] args)
        {
                DivisionNumber d = new DivisionNumber();
                d.division(25, 5);
                Console.ReadKey();
            }

        }
    }
}
