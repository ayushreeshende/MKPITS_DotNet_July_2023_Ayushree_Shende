using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections__list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lang = new List<string>();
            lang.Add("c");
            lang.Add("c#");
            lang.Add("php");
            lang.Add("oracle");
            lang.Add("php");
            lang.Add("js");
            lang.Add("mvc");
            Console.WriteLine(lang.Contains("c#"));
            
            Console.WriteLine(lang[1]);
            Console.WriteLine(lang[2]);
            Console.WriteLine("---------after removing-------");
            
            lang.Remove("c");
            lang.Remove("c#");
            foreach (string langs in lang)
            {
                Console.WriteLine(langs);
            }



            

            Console.WriteLine("------after inserting------");
            lang.Insert(4, "Haskell");
            foreach (string langs in lang)
            {
                Console.WriteLine(langs);
            }


            Console.WriteLine("-----after sorting------");
            lang.Sort();

            foreach (string langs in lang)
            {
                Console.WriteLine(langs);
            }


            Console.ReadKey();


        }
    }
}
