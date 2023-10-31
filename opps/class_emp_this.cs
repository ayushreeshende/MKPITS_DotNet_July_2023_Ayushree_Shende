using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_emp_this
{
    class Customer
    {
        int customer_code;
        string customer_name;
        public void getdata(int customer_code, string customer_name)
        {
            this.customer_code = customer_code;
            this.customer_name = customer_name;
        }
        public void displaydata()
        {
            Console.WriteLine("cust_code" + customer_code);
            Console.WriteLine("cust_name" + customer_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int cus_code;
            string customer_name;
            Customer cust = new Customer();
            Console.WriteLine("enter customer_code & customer_name");
            cus_code = Convert.ToInt32(Console.ReadLine());
            customer_name = Convert.ToString(Console.ReadLine());
            cust.getdata(cus_code, customer_name);
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
