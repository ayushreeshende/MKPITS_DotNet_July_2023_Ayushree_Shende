using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_animal
{
  public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("bread eating");
        }
    }

 internal class Program
    {
        static void Main(string[] args)
        {
            animal a= new dog();
            a.eat();
            Console.ReadKey();

        }
    }
}
