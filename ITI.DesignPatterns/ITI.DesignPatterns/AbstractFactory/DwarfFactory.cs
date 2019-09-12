using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactory
{
    public class DwarfFactory : CharacterFactory
    {
        public override ICharacter Create(string lastName, string firstName) => throw new NotImplementedException();
    }
}
