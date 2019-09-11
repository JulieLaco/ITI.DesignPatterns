using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public enum CharacterType
    {
        Human, 
        Dwarf
    }

    public class Factory
    {
        readonly Dictionary<CharacterType, CharacterFactory> _factories;

        public Factory()
        {
            _factories = new Dictionary<CharacterType, CharacterFactory>
            {
                {CharacterType.Human, new HumanFactory() },
                {CharacterType.Dwarf, new DwarfFactory() }
            };
        }

        public ICharacter CreateCharacter(CharacterType type, string lastName, string firstName) => _factories[type].Create(lastName, firstName);
    }
}
