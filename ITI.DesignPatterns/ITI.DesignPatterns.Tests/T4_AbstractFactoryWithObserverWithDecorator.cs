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

            {
                ICar renaultClioCar = new Factory(BrandModel.Renault).CreateRenault(RenaultModel.Clio);
                renaultClioCar.GetBrandModel().Should().Be(BrandModel.Renault);
                renaultClioCar.GetModel().Should().Be(RenaultModel.Clio.ToString());
            }

            {
                ICar toyotaAigoCar = new Factory(BrandModel.Toyota).CreateToyota(ToyotaModel.Aigo);
                toyotaAigoCar.GetBrandModel().Should().Be(BrandModel.Toyota);
                toyotaAigoCar.GetModel().Should().Be(ToyotaModel.Aigo.ToString());
            }

            {
                ICar toyotaYarisCar = new Factory(BrandModel.Toyota).CreateToyota(ToyotaModel.Yaris);
                toyotaYarisCar.GetBrandModel().Should().Be(BrandModel.Toyota);
                toyotaYarisCar.GetModel().Should().Be(ToyotaModel.Yaris.ToString());
            }
        }
    }
}
