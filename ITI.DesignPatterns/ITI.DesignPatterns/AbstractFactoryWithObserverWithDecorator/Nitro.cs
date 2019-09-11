using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Nitro : DecoratorBase
    {
        public Nitro(ICar car) 
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
