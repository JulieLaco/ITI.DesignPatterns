using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactory
{
    public class Human
    {
        public Human(string lastName, string firstName) { throw new NotImplementedException(); }

        public string LastName { get; }

        public string FirstName { get; }
    }
}
