using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator.Classes
{
    class Wizard : Decorator
    {
        public Wizard(Character character)
            :base(character)
        {

        }

        public override string DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
