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
        public override ICar CreateCar(ToyotaModel toyotaModel) => new Toyota(BrandModel.Toyota, toyotaModel);

        public override ICar CreateCar(RenaultModel renaultModel) => throw new Exception("Cannot create a Renault model from Toyota factory");
    }
}
