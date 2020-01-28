using ITI.DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Visitor.Classes
{
    public class DwarfPub : IPub
    {
        public void Accept(IHumanTrader trader)
        {
            trader.VisitDwarfPub(this);
        }

        public void DrinkBeer()
        {
            throw new NotImplementedException();
        }

        public string InsultTheElves()
        {
            return "";
        }
    }
}
