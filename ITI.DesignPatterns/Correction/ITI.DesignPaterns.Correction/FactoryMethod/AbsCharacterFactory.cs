using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public abstract class AbsCharacterFactory
    {
        public abstract ICharacterInfos CharacterInfosMethod();
        public abstract ICharacterItems CharacterItemsMethod();

        public string FirstName()
        {
            return CharacterInfosMethod().GetCharacterFirstName();
        }

        public string LastName()
        {
            return CharacterInfosMethod().GetCharacterLastName();
        }

        public List<string> Stuff()
        {
            return CharacterItemsMethod().GetStuff();
        }
    }
}
