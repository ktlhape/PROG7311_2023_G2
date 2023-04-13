using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class EmployeeTester
    {
        static void Main(string[] args)
        {
            EmployeeBuilder em = new EmployeeBuilder()
           .WithStaffNo("")
                .WithName("Kabelo", "Tlhape")
                .WithSalary(12000).Build();

            Console.WriteLine(em.ToString());

            Console.Read();


        }
    }
}
