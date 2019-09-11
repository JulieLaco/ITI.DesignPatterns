using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Fins : DecoratorBase
    {
        public Fins(ICar car) 
            : base(car)
        {
        }

        public int SpeedBoost { get { throw new NotImplementedException(); } }

        public override int Accelerate()
        {
            throw new NotImplementedException();
        }
    }
}
