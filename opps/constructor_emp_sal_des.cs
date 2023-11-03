using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_emp_sal_desig
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;
        public Employee()
        {
            empno = 234;
            empname = "khushi";
            designation = "manager";
            salary = 8000;
        }
        public void display()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empname=" + empname);
            Console.WriteLine("designation=" + designation);
            Console.WriteLine("salary=" + salary);

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee e = new Employee();
                e.display();
                Console.ReadKey();

            }
        }
    }
}
