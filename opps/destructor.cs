using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor
{
    class employee
    {
        public employee()
        {
            Console.WriteLine("constructor called");
        }
        ~employee()
        {
            Console.WriteLine("destructor called");
        }
    }
    class program
    {

   
        static void Main(string[] args)
        {
            employee emp = new employee();
            Console.ReadKey();
            employee emp1 = new employee();
            Console.ReadKey();/
        }
    }
}





















