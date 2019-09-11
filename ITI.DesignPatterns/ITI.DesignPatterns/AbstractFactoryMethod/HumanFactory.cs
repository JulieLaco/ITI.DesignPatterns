using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public class HumanFactory : CharacterFactory
    {
        public override ICharacter Create(string lastName, string firstName) => throw new NotImplementedException();
    }
}
