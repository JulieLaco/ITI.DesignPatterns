using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Decorator
{
    class PlayerCharacter : Character
    {
        public IList<string> Inventory { get; set; }

        public override string DisplayInfo()
        {
            return "Je suis un personnage joueur";
        }
    }
}
