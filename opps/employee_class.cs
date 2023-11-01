using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_class
{
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public int Salary { get; set; }

    }
    class program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Employee Name:");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Id:");
                int eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Salary:");
                int sal = Convert.ToInt32(Console.ReadLine());

                emp[i] = new Employee
                {
                    Name = ename,
                    EmployeeId = eid,
                    Salary = sal
                };
            }

            Employee highestPaidEmployee = emp[0];
            for (int i = 1; i < emp.Length; i++)
            {
                if (emp[i].Salary > highestPaidEmployee.Salary)
                {
                    highestPaidEmployee = emp[i];
                }
            }

            Console.WriteLine("Employee with the highest salary:");
            Console.WriteLine("Name: " + highestPaidEmployee.Name);
            Console.WriteLine("Employee id: " + highestPaidEmployee.EmployeeId);
            Console.WriteLine("Salary: " + highestPaidEmployee.Salary);

            Console.ReadKey();
        }
    }
}
