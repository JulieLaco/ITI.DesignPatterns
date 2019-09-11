using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod2
{
    public enum CharacterType
    {
        Human, 
        Dwarf
    }

    public class Character
    {
        readonly Dictionary<CharacterType, CharacterFactory> _factories;
        public Character()
        {
            _factories = new Dictionary<CharacterType, CharacterFactory>
            {
                {CharacterType.Human, new HumanFactory() },
                {CharacterType.Dwarf, new DwarfFactory() }
            };
        }

        public ICharacter ExecuteCreation(CharacterType type, string lastName, string firstName) => _factories[type].Create(lastName, firstName);
    }
}
