using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class DecoratorBase : ICar
    {
        public DecoratorBase(ICar car)
        {
            throw new NotImplementedException();
        }

        public int GetMaxSpeed => throw new NotImplementedException();

        public virtual int Accelerate()
        {
            throw new NotImplementedException();
        }

        public BrandModel GetBrandModel()
        {
            throw new NotImplementedException();
        }

        public string GetModel()
        {
            throw new NotImplementedException();
        }
    }
}
