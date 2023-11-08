using static_constructor_employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_employee
{
   class employee
    {




        static string name;// Static constructor
        static employee()
        {
            Console.WriteLine("static constructor called");
            name = "raju";
        }
    
    public static void Salary()
    {
        Console.WriteLine();
        Console.WriteLine("The Salary method");
    }
}
class details
{
    static void Main()
    {
        Console.WriteLine("----------Static constrctor example by vithal wadje------------------");
        Console.WriteLine();
        employee.Salary();
        Console.ReadKey();
    }
}
}
