using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_fields
{
    public class empoyee
    {
        public int salary=1000;

    }
    public class programmer:empoyee
    {
        public float bonus=500;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p1 = new programmer();
          
            Console.WriteLine("salary:"+p1.salary);
            Console.WriteLine("bonus:"+p1.bonus);
            Console.ReadKey();
        }
    }
}
