using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public enum CharacterType
    {
        Human
    }

    public class Factory
    {
        public ICharacter CreateCharacter(CharacterType type, string lastName, string firstName) => throw new NotImplementedException();
    }
}
