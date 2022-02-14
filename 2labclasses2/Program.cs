using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labclasses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee("John", "Kennedy", DateTime.Parse("14.02.2027"));
            Console.WriteLine("Name is {0}, surname is {1}. Date of hire: {2}", one.Name, one.Surname, one.DateOfHire);
            double salary = one.Calculation(Employee.Position.President);
            Console.WriteLine("Salary is {0}, tax is {1}, position is {2}.", salary, salary * 0.45, Employee.Position.President);
            Console.ReadKey();
        }
    }

}
