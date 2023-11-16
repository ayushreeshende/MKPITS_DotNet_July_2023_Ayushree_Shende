using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_leve_inheritance_employeefields
{
    class person
    {
        public string name;
        public string address;
    }
    class employee:person
    {
        public int empno;
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.name = "sumit";
            e.address = "chennai";
            e.empno = 2;
            e.salary = 7000;
            e.designation = "clerk";
            Console.WriteLine("name:"+e.name);
            Console.WriteLine("address:" + e.address);
            Console.WriteLine("empno:" + e.empno);
            Console.WriteLine("salary:" + e.salary);
            Console.WriteLine("designation:" + e.designation);
            Console.ReadKey();
            
        }
    }
}
