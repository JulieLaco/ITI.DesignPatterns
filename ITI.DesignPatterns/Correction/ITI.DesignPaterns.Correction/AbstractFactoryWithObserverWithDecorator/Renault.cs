using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Renault : ICar
    {
        public Renault(BrandModel brandModel, RenaultModel renaultModel)
        {
            BrandModel = brandModel;
            RenaultModel = renaultModel;
        }

        BrandModel BrandModel { get; }
        RenaultModel RenaultModel { get; }

        public int MaxSpeed { get { return 80; } }

        public int Accelerate()
        {
            return MaxSpeed;
        }

        public BrandModel GetBrandModel() => BrandModel;

        public string GetModel() => RenaultModel.ToString();
    }
}
