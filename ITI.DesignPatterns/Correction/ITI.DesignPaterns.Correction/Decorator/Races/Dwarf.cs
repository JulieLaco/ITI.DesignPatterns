using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator.Races
{
    class Dwarf : Decorator
    {
        public Dwarf(Character character) 
            : base(character)
        {
        }
    }
}
