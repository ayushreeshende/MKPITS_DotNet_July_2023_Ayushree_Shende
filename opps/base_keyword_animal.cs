using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_keyword_animal
{
    class animal
    {
        public string color = "red";
    }
    class dog:animal
    {
        public string color = "white";

        public void displaycolor()
            
        {
            Console.WriteLine("dogcolor:" + color);
            Console.WriteLine("animalcolor:" + base.color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dog d = new dog();
            d.displaycolor();
            Console.ReadKey();
        }
    }
}
