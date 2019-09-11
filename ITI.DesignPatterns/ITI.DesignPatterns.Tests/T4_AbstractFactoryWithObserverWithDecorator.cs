using FluentAssertions;
using ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator;
using ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Decorators;
using NUnit.Framework;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    public class T4_AbstractFactoryWithObserverWithDecorator
    {
        [Test]
        public void T1_abstract_factory_method_test()
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

        [Test]
        public void T2_observer()
        {
            {
                Subscriber subscriber = new Subscriber("Tim", "Tom");
                subscriber.FirstName.Should().Be("Tim");
                subscriber.LastName.Should().Be("Tom");

                Factory toyotaFactory = new Factory(BrandModel.Toyota);
                toyotaFactory.CarFactory.GetFactoryName().Should().Be("Toyota");

                subscriber.Subscription(toyotaFactory.CarFactory);

                subscriber.GetNotifications().Should().BeEmpty();

                ICar createCar = toyotaFactory.CarFactory.CreateCar(ToyotaModel.Yaris);

                subscriber.GetNotifications().Should().NotBeEmpty();
                subscriber.GetNotifications()[0].Car.Should().Be(createCar);

                subscriber.Unsubscribe(toyotaFactory.CarFactory);
            }
            {
                Staff staff = new Staff("Antoine", "Raquillet");
                staff.FirstName.Should().Be("Antoine");
                staff.LastName.Should().Be("Raquillet");

                Factory renaultFactory = new Factory(BrandModel.Renault);
                renaultFactory.CarFactory.GetFactoryName().Should().Be("Renault");

                staff.Subscription(renaultFactory.CarFactory);

                staff.GetNotifications().Should().BeEmpty();

                ICar createCar = renaultFactory.CarFactory.CreateCar(RenaultModel.Megane);

                staff.GetNotifications().Should().NotBeEmpty();
                staff.GetNotifications()[0].Car.Should().Be(createCar);

                staff.Unsubscribe(renaultFactory.CarFactory);
            }
            {
                Visitor visitor = new Visitor();

                Factory renaultFactory = new Factory(BrandModel.Renault);
                renaultFactory.CarFactory.GetFactoryName().Should().Be("Renault");

                visitor.Subscription(renaultFactory.CarFactory);

                visitor.GetNotifications().Should().BeEmpty();

                ICar createCar = renaultFactory.CarFactory.CreateCar(RenaultModel.Twingo);

                visitor.GetNotifications().Should().NotBeEmpty();
                visitor.GetNotifications()[0].Car.Should().Be(createCar);

                visitor.Unsubscribe(renaultFactory.CarFactory);
            }
        }

        [Test]
        public void T3_create_A_Renault_with_Turbo()
        {
            ICar renaultCar = new Factory(BrandModel.Renault).CreateRenault(RenaultModel.Clio);
            var nitroCar = new Nitro(renaultCar);

            nitroCar.Accelerate().Should().Be(renaultCar.GetMaxSpeed + nitroCar.SpeedBoost);
        }

        [Test]
        public void T4_create_A_Toyota_with_Turbo()
        {
            ICar toyotaCar = new Factory(BrandModel.Toyota).CreateToyota(ToyotaModel.Yaris);
            var nitroCar = new Nitro(toyotaCar);

            nitroCar.Accelerate().Should().Be(toyotaCar.GetMaxSpeed + nitroCar.SpeedBoost);
        }
    }
}
