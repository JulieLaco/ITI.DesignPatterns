using FluentAssertions;
using ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator;
using NUnit.Framework;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    public class T4_AbstractFactoryWithObserverWithDecorator
    {
        [Test]
        public void T1_create_car()
        {
            Factory factory = new Factory();
            IBrand toyotaCar = factory.CreateCar(BrandModel.Toyota);
            toyotaCar.GetBrandModel().Should().Be(BrandModel.Toyota);

            IBrand renaultCar = factory.CreateCar(BrandModel.Renault);
            renaultCar.GetBrandModel().Should().Be(BrandModel.Renault);

            //Factory factory = new Factory();
            //CarFactory carFactory = factory.CreateCarFactory();
            //carFactory.CreateToyota();

            //factory.createCarFactory().CreateToyota()
        }
    }
}
