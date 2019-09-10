using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator
{
    class NonPlayerCharacter : Character
    {
        public string Speech { get; set; }

        public override string DisplayInfo()
        {
            return "Je suis un personnage non joueur";
        }
    }
}
