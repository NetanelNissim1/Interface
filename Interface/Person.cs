using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   abstract class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;

        protected Person(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public abstract void Greet();

        public virtual void VirtualMethd()
        {
            Console.WriteLine("Hello from Base Class!");
        }

        public string GetFullName()
        {
            return $"{this._firstName} - {this._lastName}";
        }
    }
}
