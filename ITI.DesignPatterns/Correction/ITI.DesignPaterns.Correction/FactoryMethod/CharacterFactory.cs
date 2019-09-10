using System;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class CharacterFactory
    {
        public Character CreateDefaultCharacter(string firstName, string lastName)
        {
            return new Character(firstName, lastName, 4);
        }

        public Character CreateGnomeLepreux(string firstName, string lastName)
        {
            return new Character(firstName, lastName, 1);
        }

        public Character CreateFEMME(string firstName, string lastName)
        {
            return new Character(firstName, lastName, 2);
        }

        public Character CreateRhumanoïde(string firstName, string lastName)
        {
            return new Character(firstName, lastName, 3);
        }
    }
}
