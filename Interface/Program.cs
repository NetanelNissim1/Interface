using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person nati = new Nati("Nati", "Nissim");
            Console.WriteLine(nati.GetFullName());
            nati.Greet();
            nati.VirtualMethd();

            Person bill = new Bill("Bill", "Nissim");
            Console.WriteLine(bill.GetFullName());
            bill.Greet();

        }
    }
}
