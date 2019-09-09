using System;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class Character
    {
        public CharacterFactory CreateCharacter()
        {
            return new CharacterFactory();
        }
    }
}
