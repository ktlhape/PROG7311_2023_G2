using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Abstraction
{
    internal class FullTime : Student
    {
        public override void RegisterForCourse()
        {
            Console.WriteLine("Register for full time classes");
        }
    }
}
