using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class dog:animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal d = new dog();
                d.eat();
            Console.ReadKey();
        }
    }
}
