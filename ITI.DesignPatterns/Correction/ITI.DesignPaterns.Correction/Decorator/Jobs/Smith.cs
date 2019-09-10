using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator.Jobs
{
    class Smith : Decorator
    {
        public Smith(Character character) 
            : base(character)
        {
        }
    }
}
