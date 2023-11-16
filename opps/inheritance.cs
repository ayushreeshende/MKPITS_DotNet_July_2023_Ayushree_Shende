using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class person
    {
        public string name;

    }
    class student:person
    {
        public int rno;

    }
    class program
    {

    

        static void Main(string[] args)
        {
            student s = new student();
            s.name = "amit";
            s.rno = 23;
            Console.WriteLine("name:" +s. name);
            Console.WriteLine("rno:" +s. rno);
            Console.ReadLine();

        }
    }
}
