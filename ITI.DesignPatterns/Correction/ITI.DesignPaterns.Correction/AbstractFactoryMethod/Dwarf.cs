using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public class Dwarf : ICharacter
    {
        public Dwarf(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string LastName { get; }

        public string FirstName { get; }

        public string GetFirstName() => FirstName;

        public string GetLastName() => LastName;

        public string Walk()
        {
            return "je marche !";
        }
    }
}
