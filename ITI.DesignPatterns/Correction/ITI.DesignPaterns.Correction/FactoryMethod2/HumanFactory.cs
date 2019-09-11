using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod2
{
    public class HumanFactory : CharacterFactory
    {
        public override ICharacter Create(string lastName, string firstName) => new Human(lastName, firstName);
    }
}
