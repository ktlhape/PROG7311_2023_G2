using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class Employee
    {
        public string StaffNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string staffNo, string name, string surname, string email, string username, string password, int age, double salary)
        {
            StaffNo = staffNo;
            Name = name;
            Surname = surname;
            Email = email;
            Username = username;
            Password = password;
            Age = age;
            Salary = salary;
        }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Employee(string staffNo)
        {
            StaffNo = staffNo;
        }

        public Employee(string staffNo, string name, string surname) : this(staffNo, name)
        {
            Surname = surname;
        }

    }
}
