using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod.CharacterData
{
    public class CharacterItemsList
    {
        public List<string> GetCharacterDefaultStuff(int characterType)
        {
            switch (characterType)
            {
                case 1:
                    return new List<string>
                    {
                        "bombe", "briquet", "couteau"
                    };
                case 2:
                    return new List<string>
                    {
                        "oeufs", "pingouin", "corde"
                    };
                case 3:
                    return new List<string>
                    {
                        "alcool", "briquet", "tissus"
                    };
                default:
                    return new List<string>
                    {
                        "hache", "bouclier", "heaume", "plastron", "jambière", "bottes",
                        "épaulettes", "bière", "gilet en mithril", "bague de force +2"
                    };
            }
        }
    }
}
