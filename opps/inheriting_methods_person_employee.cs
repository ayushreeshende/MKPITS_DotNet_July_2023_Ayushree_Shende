using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_methods_person_employee
{
    public class person
    {
        string name;
        string address;
        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);


        }
        class employee : person
        {
            int empno;
            int salary;
            public void getemployeedata(int empno, int salary)
            {
                this.empno = empno;
                this.salary = salary;
            }
            public void displayemployeedata()
            {
                Console.WriteLine("empno:" + empno);
                Console.WriteLine("salary:" + salary);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                employee e1 = new employee();
                e1.getpersondata("ankush", "warora");
                e1.getemployeedata(23, 2300);
                e1.displaypersondata();
                e1.displayemployeedata();
                Console.ReadKey();
            }
        }
    }

}
