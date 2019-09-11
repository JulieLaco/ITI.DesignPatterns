using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public enum RenaultModel
    {
        Twingo,
        Clio,
        Megane
    }
    public class RenaultFactory : CarFactory
    {
        public RenaultFactory(string factoryName)
        {
            throw new NotImplementedException();
        }

        public override ICar CreateCar(ToyotaModel toyotaModel) => throw new Exception("Cannot create Toyota model from Renault factory");

        public override ICar CreateCar(RenaultModel renaultModel)
        {
            throw new NotImplementedException();
        }

        public override string GetFactoryName() => throw new NotImplementedException();

        public override void AddClient(IClient client) => throw new NotImplementedException();
        public override void RemoveClient(IClient client) => throw new NotImplementedException();

        Notification CreateNotification(ICar car) => throw new NotImplementedException();

        void AddNotifications(Notification notification) => throw new NotImplementedException();

        void NotifyClient(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
