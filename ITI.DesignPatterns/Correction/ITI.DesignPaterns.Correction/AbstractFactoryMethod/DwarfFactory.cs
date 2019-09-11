using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public class DwarfFactory : CharacterFactory
    {
        public override ICharacter Create(string lastName, string firstName) => new Dwarf(lastName, firstName);
    }
}
