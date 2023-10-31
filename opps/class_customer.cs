using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Customer
{
    class Customer
    {
        public int Customer_code;
        public string Customer_name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Customer_code = 123;
            cust.Customer_name = "arpit";
            Console.WriteLine("customer_code:"+cust.Customer_code);
            Console.WriteLine("cust_nmme:"+cust.Customer_name);
            Console.ReadKey();
        }
        
    }
}
