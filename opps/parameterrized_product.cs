using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_product
{
    class product
    {
        int productid;
        string productname;
        int price;
        int quatity;
        public product()
        {
            console.writeline();
            productid = 123;
            productname = "milk";
            price = "400";
            quatity = 20;
        }
        public product(int productid, string productname, int price, int quantity);
        {
        console.writeline("");
            this.productid=productid;
            this.productname=productname;
            this.price=price;
            this.quantiy=quantity;

    }
    public void display()
    {
        console.writeline("productid=" + productid);
        console.writeline("productname=" + productname);
        console.writeline("price="+price)
    }
    class program
    {
      
        static void Main(string[] args)
        {
            product p1 = new product();
            p1.display();
            product p2 = new product(123, "milk", 400, 20);
            p2.display();
            console.Readkey();
        }
    }
}
