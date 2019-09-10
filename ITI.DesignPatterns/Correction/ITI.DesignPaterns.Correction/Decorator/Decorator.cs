﻿namespace ITI.DesignPatterns.Decorator
{
    abstract class Decorator : Character
    {
        protected Character character;

        public Decorator(Character character)
        {
            this.character = character;
        }

        public override string DisplayInfo()
        {
            return character.DisplayInfo();
        }
    }
}
