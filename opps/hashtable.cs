using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace hashtable
{
     class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("123", "amit");
            ht.Add("001", "nora");
            ht.Add("004", "hritik");
            ht.Add("009", "rohit");
            ht.Add("345", "kamlesh");
            if (ht.ContainsValue(" sumit"))
            {


                Console.WriteLine("the student name already in the list");
            }
            else

            {
                ht.Add("008", "sumit");
            }
            

            
            
              ICollection key= ht.Keys;
            
                foreach(string s in key)
                {

                    Console.WriteLine(s + ": " + ht[s]);
                }
              
                    Console.ReadKey();
                }
            }
                    
        }
    

