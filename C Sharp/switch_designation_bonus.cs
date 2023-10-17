using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designationbonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designation;
            int bonus = 0;
            Console.WriteLine("enter designation manager,clerk,peon");
            designation = Console.ReadLine();
            switch(designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 1000;
                    break;
                default:
                    Console.WriteLine("invalid designation");
                        break;
            }
            Console.WriteLine("bonus={0}", bonus);
            Console.ReadKey();
        }
    }
}
