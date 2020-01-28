using ITI.DesignPatterns.Visitor.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Visitor.Interfaces
{
    public interface IHumanTrader
    {
        void VisitElfPub(ElfPub elfPub);
        void VisitDwarfPub(DwarfPub dwarfPub);
    }
}
