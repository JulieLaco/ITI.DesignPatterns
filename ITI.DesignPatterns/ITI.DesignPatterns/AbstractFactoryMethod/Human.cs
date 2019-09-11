using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public class Human
    {
        public Human(string lastName, string firstName) { }

        public string LastName { get; }

        public string FirstName { get; }
    }
}
