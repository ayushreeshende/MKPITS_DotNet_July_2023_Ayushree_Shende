using runtime_polymorphism_animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_animal
{
    public class animal
    {
        public string color = "red";


    }

    public class dog : animal
    {
        public string color = "black";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal d = new dog();
            Console.WriteLine(d.color);
            Console.ReadKey();
        }
    }

}