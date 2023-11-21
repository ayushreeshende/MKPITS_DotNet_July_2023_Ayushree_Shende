using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_nonabstract_account
{
    abstract class person
    {
        public abstract void display();
        public void showdata()

        {
            Console.WriteLine("hello from showdata");


        }
    }
    class student : person
    {
        public override void display()

        {
            Console.WriteLine("hello from display method");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.display();
                s.showdata();
                Console.ReadKey();
            }
        }
    }
}