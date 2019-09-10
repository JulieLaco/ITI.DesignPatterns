using System;
using System.Collections.Generic;
using System.IO;
using ITI.DesignPatterns.FactoryMethod.CharacterData;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class Character : AbsCharacter
    {
        readonly int _characterType;
        readonly string _firstName;
        readonly string _lastName;

        public Character(string firstName, string lastName, int characterType)
        {
            _characterType = characterType;
            _firstName = firstName;
            _lastName = lastName;
        }

        public override ICharacterItems CharacterItemsMethod()
        {
            return new CharacterItems(_characterType);
        }

        public override ICharacterInfos CharacterInfosMethod()
        {
            return new CharacterInfos(_firstName, _lastName, _characterType);
        }
    }
}
