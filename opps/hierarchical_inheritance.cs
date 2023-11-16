using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance
{
    class person
    {
     public   string name;
       public string address;
    }
    class student:person
    {
        public int rno;
     public   int marks;
    }
    class employee:person
    {
       public int salary;
     public   string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "sumit";
            s1.address = "mumbai";
            s1.rno = 123;
            s1.marks = 450;
            Console.WriteLine("-----student details----");
            Console.WriteLine("name:" +s1.name);
            Console.WriteLine("address:" + s1.address);
            Console.WriteLine("rno:" + s1.rno);
            Console.WriteLine("marks:" + s1.marks);
        
        employee emp = new employee();
            emp.name="sumit";
            emp.address="mumbai";
            emp.salary=45670;
            emp.designation="clerk";

            Console.WriteLine("----emp details-----");
            Console.WriteLine("name:" + emp.name);
            Console.WriteLine("address:" + emp.address);
            Console.WriteLine("salary:" + emp.salary);
            Console.WriteLine("designation:" + emp.designation);
            Console.ReadKey();
        }
    }
    }
   
