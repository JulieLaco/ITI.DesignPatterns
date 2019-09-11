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
    public class RenaultFactory : CarFactory
    {
        public override ICar CreateCar(ToyotaModel toyotaModel) => throw new Exception("Cannot create Toyota model from Renault factory");

        public override ICar CreateCar(RenaultModel renaultModel) => new Renault(BrandModel.Renault, renaultModel);
    }
}
