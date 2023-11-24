using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace sorted_list_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("102", "khush");
            sl.Add("103", "monty");
            sl.Add("104", "tinu");
            sl.Add("105", "mahesh");

            if (sl.ContainsValue("hardik"))
            {


                Console.WriteLine("the student have already in the list");
            }
            else
            {
                sl.Add("008", "ashish");
            }
            ICollection key = sl.Keys;
            foreach (string s in key)
            {

                Console.WriteLine(s + ": " + sl[s]);
                Console.ReadKey();
            }


        }
    }
}
           
    
   