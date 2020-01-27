using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactory
{
    public enum CharacterType
    {
        Human,
        Dwarf
    }

    public class Factory
    {
        public ICharacter CreateCharacter(CharacterType type, string lastName, string firstName) => throw new NotImplementedException();
    }
}
