using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_employee
{
    class employee
    {
        protected int salary;
    }
    class programmer : employee
    {
        int bonus;


        public void getdata(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;


        }
        public void displaydata()

        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("bonus:" + bonus);

        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {
                programmer p1 = new programmer();
                p1.getdata(1500, 400);
                p1.displaydata();
                Console.ReadKey();
            }
        }
    }

