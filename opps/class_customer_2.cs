using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer2
{
    class Customer
    {
        int customer_code;
        string customer_name;
        public void getdata(int cc,string cn)
        {
            customer_code = cc;
            customer_name = cn;

        }
        public void displaydata()
        {
            Console.WriteLine("cust_code:" + customer_code);
            Console.WriteLine("cust_name:" + customer_name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata  (123, "amit");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
