using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class ExecutePrinter
    {
        static void Main(string[] args)
        {
            Printer p1 = Printer.GetInstance();
            Printer p2 = Printer.GetInstance();

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
        }


    }
}
