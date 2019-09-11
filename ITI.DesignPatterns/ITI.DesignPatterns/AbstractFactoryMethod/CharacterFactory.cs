using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public abstract class CharacterFactory
    {
        public abstract ICharacter Create(string lastName, string firstName);
    }
}
