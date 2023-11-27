using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_tkey_tvalue_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> domains = new Dictionary<string, string>();

            domains.Add("de", "decan");
            domains.Add("ge", "germany");
            domains.Add("as", "australia");
            domains.Add("eu", "europe");
            domains.Add("af", "africa");
            domains.Add("in", "indonsia");
            Console.WriteLine(domains["de"]);
            Console.WriteLine(domains["ge"]);
            Console.WriteLine("dictionary has {0}items", domains.Count);
            Console.WriteLine("keys of dictionary");

            List<string> keys = new List<string>(domains.Keys);

            foreach (string key in keys) ;
            {
                Console.WriteLine("{0}", keys);
                Console.WriteLine("vaues of dictionary");


                List<string> vals = new List<string>(domains.Values);

                foreach (string val in vals)
                {
                    Console.WriteLine("{0}", val);
                }

                Console.WriteLine("Keys and values of the dictionary:");


                foreach (KeyValuePair<string, string> kvp in domains)
                {
                    Console.WriteLine("Key = {0}, Value = {1}",
                        kvp.Key, kvp.Value);
                    Console.ReadKey();

                }
            }

        }
    }
}

    