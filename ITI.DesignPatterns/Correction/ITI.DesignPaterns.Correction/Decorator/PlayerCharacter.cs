using System.Collections.Generic;

namespace ITI.DesignPatterns.Decorator
{
    class PlayerCharacter : Character
    {
        public IList<string> Inventory { get; set; }

        public override string DisplayInfo()
        {
            return "I'm a player character, my name is " + base.Name;
        }
    }
}
