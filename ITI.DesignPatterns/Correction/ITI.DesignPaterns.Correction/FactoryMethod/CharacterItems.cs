using ITI.DesignPatterns.FactoryMethod.CharacterData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    class CharacterItems : ICharacterItems
    {
        public CharacterItems(int characterType)
        {
            CharacterItemsList characterItems = new CharacterItemsList();
            Stuff = characterItems.GetCharacterDefaultStuff(characterType);
        }

        List<string> Stuff { get; set; }

        public List<string> GetStuff() => Stuff;
    }
}
