using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public enum ToyotaModel
    {
        Yaris,
        Rav4,
        Aigo
    }

    public class ToyotaFactory : CarFactory
    {
        public ToyotaFactory(string factoryName)
        {
            throw new NotImplementedException();
        }

        public override ICar CreateCar(ToyotaModel toyotaModel)
        {
            throw new NotImplementedException();
        }

        public override ICar CreateCar(RenaultModel renaultModel) => throw new Exception("Cannot create a Renault model from Toyota factory");

        public override string GetFactoryName() => throw new NotImplementedException();

        Notification CreateNotification(ICar car) => throw new NotImplementedException();

        void AddNotifications(Notification notification) => throw new NotImplementedException();

        void NotifyClient(Notification notification)
        {
            throw new NotImplementedException();
        }

        public override void AddClient(IClient client) => throw new NotImplementedException();

        public override void RemoveClient(IClient client) => throw new NotImplementedException();
    }
}
