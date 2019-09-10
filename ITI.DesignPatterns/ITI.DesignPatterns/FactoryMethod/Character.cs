using System;
using System.Collections.Generic;
using System.IO;
using ITI.DesignPatterns.FactoryMethod.CharacterData;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class Character : AbsCharacter
    {
        public override ICharacterItems CharacterItemsMethod()
        {
            throw new NotImplementedException();
        }

        public override ICharacterInfos CharacterInfosMethod()
        {
            throw new NotImplementedException();
        }
    }
}
