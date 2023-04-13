using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class EmployeeBuilder
    {
        public string StaffNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public EmployeeBuilder WithStaffNo(string staffNo)
        {
            this.StaffNo = staffNo;
            return this;
        }
        public EmployeeBuilder WithName(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            return this;
        }
        public EmployeeBuilder WithCredentials(string username, string pass)
        {
            this.Username = username;
            this.Password = pass;
            return this;
        }
        public EmployeeBuilder WithEmail(string email)
        {
            this.Email = email;
            return this;
        }
        public EmployeeBuilder WithAge(int age)
        {
            this.Age = age;
            return this;
        }
        public EmployeeBuilder WithSalary(double sal)
        {
            this.Salary = sal;
            return this;
        }

        private bool CheckBuild()
        {
            return StaffNo.Length <= 0;
        }
        public EmployeeBuilder Build()
        {
            if (CheckBuild())
            {
                throw new Exception("Staff number needed");
            }
            return this;
        }

        public override string ToString()
        {
            return $"Staff No: {StaffNo}\n" +
                $"Name: {Name} {Surname}\n" +
                $"Email: {Email}\n" +
                $"Age: {Age}\nSalary: {Salary}";
        }

    }
}
