using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod2
{
    public abstract class CharacterFactory
    {
        public abstract ICharacter Create(string lastName, string firstName);
    }
}
