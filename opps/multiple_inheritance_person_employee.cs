using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritnce_person_employee
{
    class person
    {
        string name;
        string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void  displaypersondata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
        }
    }
    class employee:person
    {
        int salary;
        string designation;
        public void getemployeedata(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("designation:" + designation);
        }
    }
    class parttimeemployee:employee
    {
        int no_of_hours;
        public void getparttimeemployeedata(int no_of_hours)
        {
            this.no_of_hours=no_of_hours;
        }
        public void displayparttimeemployeedata()
        {
            Console.WriteLine("no_ of _hours:" + no_of_hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimeemployee p1 = new parttimeemployee();
            p1.getemployeedata(4500, "manager");
            p1.getpersondata("prunit", "kolkatta");
            p1.getparttimeemployeedata(9);
            p1.displayemployeedata();
            p1.displayparttimeemployeedata();
            p1.displaypersondata();
            Console.ReadKey();
        }
    }
}
