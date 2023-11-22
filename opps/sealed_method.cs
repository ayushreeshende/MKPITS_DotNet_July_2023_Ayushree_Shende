using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello");


    }
        class student : person
        {
            public string name;
            public override void display()
            {
                Console.WriteLine("hi");
            }

        }
        sealed class parttimestudent : student
        {

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                parttimestudent p = new parttimestudent();
                p.display();
                Console.ReadKey();
            }
        }
    }
}


