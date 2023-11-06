using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consructor_product
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;
        public Product()
        {
            productid = 123;
            productname = "wheat";
            price = 500;
            quantity = 40;

        }
        public void display()
        {
            Console.WriteLine("productid=" + productid);
            Console.WriteLine("productname=" + productname);
            Console.WriteLine("productprice=" + price);
            Console.WriteLine("productquantity=" + quantity);
        }
    } 
    class program
    {

   
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Console.ReadLine();
        }
    }
}
