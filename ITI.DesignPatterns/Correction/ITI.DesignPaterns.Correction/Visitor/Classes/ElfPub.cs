using ITI.DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Visitor.Classes
{
    public class ElfPub : IPub
    {
        public void Accept(IHumanTrader trader)
        {
            trader.VisitElfPub(this);
        }

        public void DrinkBeer()
        {
            throw new NotImplementedException();
        }

        public string MakeFunOfDwarfs()
        {
            return "to be as tall as three apples hahhaaha";
        }
    }
}
