using System;

namespace Interface
{
    internal class Bill : Person
    {
        public Bill(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public override void Greet()
        {
            Console.WriteLine("Hi Bill!!!!");
        }
    }
}