using ITI.DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Visitor.Classes
{
    public class HumanTrader : IHumanTrader
    {
        public void VisitDwarfPub(DwarfPub dwarfPub)
        {
            Console.WriteLine(dwarfPub.InsultTheElves());
        }

        public void VisitElfPub(ElfPub elfPub)
        {
            Console.WriteLine(elfPub.MakeFunOfDwarfs());
        }
    }
}
