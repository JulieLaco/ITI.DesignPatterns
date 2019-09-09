using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class CharacterInfos : ICharacterInfos
    {
        public CharacterInfos(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string LastName { get; private set; }
        public string FirstName { get; private set; }

        public string GetCharacterLastName() => LastName;
        public string GetCharacterFirstName() => FirstName;
    }
}
