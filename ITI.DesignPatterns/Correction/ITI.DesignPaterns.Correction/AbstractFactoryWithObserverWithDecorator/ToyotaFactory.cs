using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{

    public enum ToyotaModel
    {
        Yaris,
        Rav4,
        Aigo
    }

    public class ToyotaFactory : CarFactory
    {
        public override IBrand CreateCar(BrandModel brandModel) => new Toyota(brandModel);
    }
}
