using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_class
{
    class Person
    {
        
        string name;
        int age;
        string address;

        public void getdata(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void displaydata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("address:" + address);
            
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Person per= new Person();
            Console.WriteLine("enter name,age,address");
            string name = Convert.ToString(Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());
            string address = Convert.ToString(Console.ReadLine());
            per.getdata(name,age,address);
            per.displaydata();
            Console.ReadKey();
        }
    }
}
