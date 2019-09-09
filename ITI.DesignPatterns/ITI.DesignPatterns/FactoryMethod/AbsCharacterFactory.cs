using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public abstract class AbsCharacterFactory
    {
        //public abstract ICharacterInfos CharacterInfosMethod();
        //public abstract ICharacterItems CharacterItemsMethod();

        public string FirstName()
        {
            throw new NotImplementedException();
        }

        public string LastName()
        {
            throw new NotImplementedException();
        }

        public List<string> Stuff()
        {
            throw new NotImplementedException();
        }
    }
}
