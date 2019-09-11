using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public abstract class CarFactory
    {
        public abstract ICar CreateCar(ToyotaModel toyotaModel);
        public abstract ICar CreateCar(RenaultModel renaultModel);
    }
}
