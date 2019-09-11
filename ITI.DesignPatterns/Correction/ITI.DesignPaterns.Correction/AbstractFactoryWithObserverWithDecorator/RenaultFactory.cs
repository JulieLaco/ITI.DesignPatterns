using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public enum RenaultModel
    {
        Twingo,
        Clio,
        Megane
    }
    class RenaultFactory : CarFactory
    {
        public override IBrand CreateCar(BrandModel brandModel) => new Renault(brandModel);
    }
}
