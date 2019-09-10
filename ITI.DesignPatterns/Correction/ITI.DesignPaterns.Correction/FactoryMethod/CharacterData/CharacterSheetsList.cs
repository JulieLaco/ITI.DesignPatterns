using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod.CharacterData
{
    public class CharacterSheetsList
    {       
        public Tuple<string, string> GetCharacterSheet(int characterType)
        {
            switch (characterType)
            {
                case 1:
                    return Tuple.Create("Suicide bomber", "Gnome Lepreux");
                case 2:
                    return Tuple.Create("Eleveuse de pingoui-corne", "Humain de type FEMME");
                case 3:
                    return Tuple.Create("Alcoolique", "Rhumanoïde");
                default:
                    return Tuple.Create("Guerrier", "Nain");
            }
        }
    }
}
