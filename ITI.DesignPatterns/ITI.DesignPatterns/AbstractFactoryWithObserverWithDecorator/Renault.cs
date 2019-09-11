using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Renault : ICar
    {
        public Renault(BrandModel brandModel, RenaultModel renaultModel)
        {
            throw new NotImplementedException();
        }

        public int GetMaxSpeed { get { throw new NotImplementedException(); } }

        public int Accelerate()
        {
            throw new NotImplementedException();
        }

        public BrandModel GetBrandModel() => throw new NotImplementedException();

        public string GetModel() => throw new NotImplementedException();
    }
}
