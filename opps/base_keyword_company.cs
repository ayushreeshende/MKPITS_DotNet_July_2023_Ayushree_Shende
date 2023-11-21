using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_keyword_company
{
    class company
    {
        public string name = "mahindra";
        public void display()
        {
            Console.WriteLine("company name:" + name);
        }
    }
    class european:company
    {
        public string name = "mihan";
        public void display()
        {
            base.display();
            Console.WriteLine("european name:" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            european e = new european();
            e.display();
            Console.ReadKey();
        }
    }
}
