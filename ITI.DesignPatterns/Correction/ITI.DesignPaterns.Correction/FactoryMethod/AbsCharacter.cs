using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public abstract class AbsCharacter
    {
        public abstract ICharacterInfos CharacterInfosMethod();
        public abstract ICharacterItems CharacterItemsMethod();

        public string GetFirstName()
        {
            return CharacterInfosMethod().GetCharacterFirstName();
        }

        public string GetLastName()
        {
            return CharacterInfosMethod().GetCharacterLastName();
        }

        public string GetCharacterClass()
        {
            return CharacterInfosMethod().GetCharacterClass();
        }

        public string GetCharacterType()
        {
            return CharacterInfosMethod().GetCharacterType();
        }

        public List<string> GetStuff()
        {
            return CharacterItemsMethod().GetStuff();
        }
    }
}
