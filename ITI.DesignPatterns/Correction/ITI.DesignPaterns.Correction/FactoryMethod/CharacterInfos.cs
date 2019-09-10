using ITI.DesignPatterns.FactoryMethod.CharacterData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPaterns.Correction.FactoryMethod
{
    public class CharacterInfos : ICharacterInfos
    {
        public CharacterInfos(string firstName, string lastName, int characterType)
        {
            CharacterSheetsList characterSheets = new CharacterSheetsList();
            Tuple<string, string> characterSheet = characterSheets.GetCharacterSheet(characterType);
            LastName = lastName;
            FirstName = firstName;
            CharacterType = characterSheet.Item2;
            CharacterClass = characterSheet.Item1;
        }

        public string LastName { get; }
        public string FirstName { get; }
        public string CharacterType { get; }
        public string CharacterClass { get; }


        public string GetCharacterLastName() => LastName;
        public string GetCharacterFirstName() => FirstName;
        public string GetCharacterClass() => CharacterClass;
        public string GetCharacterType() => CharacterType;
    }
}
