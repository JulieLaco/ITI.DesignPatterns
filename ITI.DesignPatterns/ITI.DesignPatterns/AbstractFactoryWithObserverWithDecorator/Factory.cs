using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public enum BrandModel
    {
        Toyota,
        Renault
    }

    public class Factory
    {
        public Factory(BrandModel brandModel)
        {
            throw new NotImplementedException();
        }

        public CarFactory CarFactory { get; }

        public ICar CreateToyota(ToyotaModel toyotaModel) => throw new NotImplementedException();
        public ICar CreateRenault(RenaultModel renaultModel) => throw new NotImplementedException();
    }
}
