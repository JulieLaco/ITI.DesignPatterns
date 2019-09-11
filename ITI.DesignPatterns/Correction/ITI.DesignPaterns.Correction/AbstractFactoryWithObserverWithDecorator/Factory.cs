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
        readonly BrandModel brand;

        public Factory(BrandModel brandModel)
        {
            brand = brandModel;
            _factories = new Dictionary<BrandModel, CarFactory>
            {
                {BrandModel.Renault, new RenaultFactory("Renault") },
                {BrandModel.Toyota, new ToyotaFactory("Toyota") }
            };
            CarFactory = _factories[brandModel];
        }

        public CarFactory CarFactory { get; }

        public ICar CreateToyota(ToyotaModel toyotaModel) => _factories[brand].CreateCar(toyotaModel);
        public ICar CreateRenault(RenaultModel renaultModel) => _factories[brand].CreateCar(renaultModel);
    }
}
