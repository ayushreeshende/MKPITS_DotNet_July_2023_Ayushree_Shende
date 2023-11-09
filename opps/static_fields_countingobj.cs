using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_counting_objects
{
    public class account
    {
        public int accno;
        public string name;
        public static int count = 0;
        public account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count++;

        }
        public void display()
        {
            Console.WriteLine(accno + "" + name);
        }
    }
    class testaccount
    {
 public static void Main(string[] args)
        {

        
            account a1 = new account(102, "ravi");
            account a2 = new account(103, "raju");
            account a3 = new account(104, "ayu");
            a1.display();
            a2.display();
            a3.display();
            Console.WriteLine("total abjects are:" + account.count);
            Console.ReadKey();
        }
    }
}
