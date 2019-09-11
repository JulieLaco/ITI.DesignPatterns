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

        public int SpeedBoost { get { return 30; } }

        public override int Accelerate()
        {
            return base.Accelerate() + SpeedBoost;
        }
    }
}
