using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Visitor.Interfaces
{
    public interface IPub
    {
        void Accept(IHumanTrader trader);
        void DrinkBeer();
    }
}
