using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_student
{
    class student
    {
        public string name { get; set; }
        public string address { get; set; }
        public string emailid { get; set; }
        public string id { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.name = "gargi";
                s.address = "mumbai";
                s.emailid = "gargi@135gmail.com";
                s.id = "123";
                Console.WriteLine("name:" + s.name);
                Console.WriteLine("address:" + s.address);
                Console.WriteLine("emailid:" + s.emailid);
                Console.WriteLine("id:" + s.id);
                Console.ReadKey();

            }
        }
    }
}
