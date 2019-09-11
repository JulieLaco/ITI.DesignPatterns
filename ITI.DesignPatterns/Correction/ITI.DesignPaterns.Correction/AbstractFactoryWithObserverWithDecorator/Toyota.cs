using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Toyota : IBrand
    {
        public Toyota(BrandModel brandModel)
        {
            BrandModel = brandModel;
        }

        public BrandModel BrandModel { get; }

        public BrandModel GetBrandModel() => BrandModel;
    }
}
