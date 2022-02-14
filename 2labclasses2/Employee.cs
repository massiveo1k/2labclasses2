using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labclasses2
{
    internal class Employee
    {
        string name;
        string surname;
        DateTime dateOfHire;
        double salary;

        public enum Position
        {
            Assistant = 1000000,
            President = 5000000
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                if (dateOfHire.Date < DateTime.Parse("14.02.2021"))
                {
                    dateOfHire = value;
                }
                else
                {
                    Console.WriteLine("Date before times!");
                }

            }
        }

        public Employee(string name, string surname, DateTime dateOfHire)
        {
            Name = name;
            Surname = surname;
            DateOfHire = dateOfHire;
        }

        public double DiscoverGrade(DateTime dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - dateOfHire).TotalDays;

            if (dateValueForGrade >= 2000 && dateValueForGrade < 4000)
                return 3.5;
            else if (dateValueForGrade >= 4000)
                return 3.0;
            else
                return 2.0;
        }

        public double Calculation(Position position)
        {
            double grade = DiscoverGrade(dateOfHire);
            switch (position)
            {
                case Position.Assistant:
                    salary = 1000000 * grade;
                    return salary;
                case Position.President:
                    salary = 5000000 * grade;
                    return salary;
                default:
                    Console.WriteLine("No such position!");
                    break;

            }
            return 0.0;
        }
    }
}
