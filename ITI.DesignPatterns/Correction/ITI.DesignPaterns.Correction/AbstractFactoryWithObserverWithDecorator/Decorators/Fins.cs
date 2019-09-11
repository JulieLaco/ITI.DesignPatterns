using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Decorators
{
    public class Fins : DecoratorBase
    {
        public Fins(ICar car) 
            : base(car)
        {
        }

        public int SpeedBoost { get { return 5; } }

        public override int Accelerate()
        {
            return base.Accelerate() + SpeedBoost;
        }
    }
}
