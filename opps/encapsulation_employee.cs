using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_employee
{
    class employee
    {
        public string empname { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empname = "shruti";
            Console.WriteLine("name:" + emp.empname);
            Console.ReadKey();
        }
    }
}