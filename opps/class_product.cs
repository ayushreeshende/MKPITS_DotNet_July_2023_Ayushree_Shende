using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_class
{
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductItem { get; set; }
        public void getdata(string productname, int productprice, int productitem)
        {
            this.ProductName = productname;
            this.ProductPrice = productprice;
            this.ProductItem = productitem;
        }
        public void display()
        {
            Console.WriteLine("product:" + ProductName);
            Console.WriteLine("price:" + ProductPrice);
            Console.WriteLine("item:" + ProductItem);
        }

    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            string name;
            int item, price;
            int total;
            int stock = 50;
            Console.WriteLine("enter productname");
            name = Console.ReadLine();
            Console.WriteLine("how much you buy");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("amount");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");
            if (item > 0 && item < stock)
            {
                int remainingstock = stock - item;
                total = price + item;
                pr.getdata(name, remainingstock, total);
                pr.display();
                Console.WriteLine("tota price you purchased:" + total);
                Console.WriteLine("remaining stock are:{0}" + remainingstock);
            }
            else
            {
                Console.WriteLine("insufficient in stock");
            }
            Console.ReadKey();
                


        }
    }
}
