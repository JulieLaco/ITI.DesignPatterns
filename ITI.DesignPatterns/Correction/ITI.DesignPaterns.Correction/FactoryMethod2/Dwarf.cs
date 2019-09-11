using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod2
{
    public class Dwarf : ICharacter
    {
        readonly string _lastName;
        readonly string _firstName;

        public Dwarf(string lastName, string firstName)
        {
            _lastName = lastName;
            _firstName = firstName;
        }

        public string Walk()
        {
            return "je marche !";
        }
    }
}
