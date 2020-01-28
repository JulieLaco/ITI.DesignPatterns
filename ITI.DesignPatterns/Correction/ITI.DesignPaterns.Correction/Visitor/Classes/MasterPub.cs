using ITI.DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Visitor.Classes
{
    public class MasterPub
    {
        public static void PubCode(List<IPub> pubs, IHumanTrader humanTrader)
        {
            foreach (var pub in pubs)
            {
                pub.Accept(humanTrader);
            }
        }
    }
}
