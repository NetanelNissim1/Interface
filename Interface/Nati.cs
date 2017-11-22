using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   internal class Nati : Person
    {
        public Nati(string firstName, string lastName):base(firstName, lastName)
        {

        }

        public override void Greet()
        {
            Console.WriteLine("Hi there!");
        }

        //public override void VirtualMethd()
        //{
        //    Console.WriteLine("Hello Nati!!!");
        //}
    }
}
