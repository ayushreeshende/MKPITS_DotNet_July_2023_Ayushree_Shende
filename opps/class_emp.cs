using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee
{
    class Employee
    {
        int empno;
        string name;
        string designation;
        int salary;
        public void getdata(int en, string n, string ds, int s)
        {
        empno=en;
            name=n;
            designation = ds;
            salary = s;
            }

    public void displaydata()
        {
            Console.WriteLine("emp:" + empno);
            Console.WriteLine("name:" + name);
            Console.WriteLine("designation:" + designation);
            Console.WriteLine("salary:" + salary);
        }



        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empno = new Employee();
            empno.getdata(123, "amit", "clerk", 5000);
            empno.displaydata();
            Console.ReadKey();
        }
    }
}
