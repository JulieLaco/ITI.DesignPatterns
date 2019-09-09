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

        public override ICharacterItems CharacterItemsMethod()
        {
            return new CharacterItems(_defaultStuff);
        }

        public override ICharacterInfos CharacterInfosMethod()
        {
            return new CharacterInfos(_character1.FirstName, _character1.LastName);
        }
    }
}
