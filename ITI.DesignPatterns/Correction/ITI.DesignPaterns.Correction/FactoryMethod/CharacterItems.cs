using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    class CharacterItems : ICharacterItems
    {
        public CharacterItems(List<string> stuff)
        {
            Stuff = stuff;
        }

        List<string> Stuff { get; set; }

        public List<string> GetStuff() => Stuff;
    }
}
