using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    class CharacterItems : ICharacterItems
    {
        public List<string> GetStuff() => throw new NotImplementedException();
    }
}
