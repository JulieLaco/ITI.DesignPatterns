using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class CharacterInfos : ICharacterInfos
    {
        public string GetCharacterLastName() => throw new NotImplementedException();
        public string GetCharacterFirstName() => throw new NotImplementedException();
    }
}
