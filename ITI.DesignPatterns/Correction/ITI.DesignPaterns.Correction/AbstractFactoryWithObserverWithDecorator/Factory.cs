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
        readonly Dictionary<BrandModel, CarFactory> _factories;

        public Factory()
        {
            _factories = new Dictionary<BrandModel, CarFactory>
            {
                {BrandModel.Renault, new RenaultFactory() },
                {BrandModel.Toyota, new ToyotaFactory() }
            };
        }

        public IBrand CreateCar(BrandModel brandModel) => _factories[brandModel].CreateCar(brandModel);
    }
}
