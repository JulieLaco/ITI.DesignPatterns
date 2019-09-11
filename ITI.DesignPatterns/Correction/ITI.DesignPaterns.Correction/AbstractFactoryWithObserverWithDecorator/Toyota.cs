using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Toyota : ICar
    {
        public Toyota(BrandModel brandModel, ToyotaModel toyotaModel)
        {
            BrandModel = brandModel;
            ToyotaModel = toyotaModel;
        }

        BrandModel BrandModel { get; }
        ToyotaModel ToyotaModel { get; }

        public BrandModel GetBrandModel() => BrandModel;

        public string GetModel() => ToyotaModel.ToString();
    }
}
