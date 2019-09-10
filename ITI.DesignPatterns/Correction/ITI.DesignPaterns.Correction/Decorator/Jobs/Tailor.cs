using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator.Jobs
{
    class Tailor : Decorator
    {
        public Tailor(Character character)
            : base(character)
        {
        }
    }
}
