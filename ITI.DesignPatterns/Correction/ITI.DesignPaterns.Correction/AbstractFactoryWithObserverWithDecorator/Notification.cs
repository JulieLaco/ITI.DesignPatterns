using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Notification
    {
        internal Notification(ICar car)
        {
            Car = car;
        }

        public ICar Car { get; }
    }
}
