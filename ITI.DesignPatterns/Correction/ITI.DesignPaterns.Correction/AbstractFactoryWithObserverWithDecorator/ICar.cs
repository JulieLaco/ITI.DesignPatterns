using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public interface ICar
    {
        BrandModel GetBrandModel();

        string GetModel();

        int Accelerate();
    }
}
