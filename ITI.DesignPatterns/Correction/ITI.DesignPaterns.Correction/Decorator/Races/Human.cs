using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator.Races
{
    class Human : Decorator
    {
        public Human(Character character) 
            : base(character)
        {
        }
    }
}
