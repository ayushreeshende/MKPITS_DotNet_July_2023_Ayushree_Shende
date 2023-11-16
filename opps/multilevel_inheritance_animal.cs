using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_animal
{
    public class animal
    {
        public void eat()
       { Console.WriteLine("eating");}
    }
public class dog : animal
{
    public void bark()
   {Console.WriteLine("barking....");}


}
        public class babydog:dog
{
    public void weep()
    { Console.WriteLine("weeping"); }
}
     

         
    internal class Program
    {
        static void Main(string[] args)
        {
            babydog d1 = new babydog();
            d1.bark();
            d1.eat();
            d1.weep();
            Console.ReadKey();
        }
    }
}
