using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class DecoratorBase : ICar
    {
        private ICar _car;

        public DecoratorBase(ICar car)
        {
            _car = car;
        }

        public int GetMaxSpeed => _car.GetMaxSpeed;

        public virtual int Accelerate()
        {
            return _car.Accelerate();
        }

        public BrandModel GetBrandModel()
        {
            return _car.GetBrandModel();
        }

        public string GetModel()
        {
            return _car.GetModel();
        }
    }
}
