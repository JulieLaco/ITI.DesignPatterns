using System;
using System.Collections.Generic;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class CharacterFactory : AbsCharacterFactory
    {
        readonly (string FirstName, string LastName) _character1 = ("Jeff", "Dunham");
        readonly List<string> _defaultStuff = new List<string>
        {
            "Axe",
            "Arrow",
            "Sword",
            "Knife"
        };

        public ICharacterItems CharacterItemsMethod()
        {
            throw new NotImplementedException();
        }

        public ICharacterInfos CharacterInfosMethod()
        {
            throw new NotImplementedException();
        }
    }
}
