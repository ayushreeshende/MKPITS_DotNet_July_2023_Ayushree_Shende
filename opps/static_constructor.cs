using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{

    public class Account
    {
        public int id;
        public String name;
        public static float rateOfInterest;
        public Account(int id, String name)
        {
            Console.WriteLine("instance constructor is called ");
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            Console.WriteLine("static constructor is called ");
            rateOfInterest = 9.5f;
        }
        public void display()
        {

            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {


            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
            Console.ReadKey();



        }
    }
}
