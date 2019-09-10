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
            throw new NotImplementedException();
        }

        public string GetLastName()
        {
            throw new NotImplementedException();
        }

        public string GetCharacterClass()
        {
            throw new NotImplementedException();
        }

        public string GetCharacterType()
        {
            throw new NotImplementedException();
        }

        public List<string> GetStuff()
        {
            throw new NotImplementedException();
        }
    }
}
