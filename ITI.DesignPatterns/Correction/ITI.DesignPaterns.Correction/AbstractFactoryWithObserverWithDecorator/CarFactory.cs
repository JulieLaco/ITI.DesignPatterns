using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public abstract class CarFactory
    {
        public abstract IBrand CreateCar(BrandModel brandModel);
    }
}
