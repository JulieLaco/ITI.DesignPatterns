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
        List<Notification> _notifications = new List<Notification>();
        List<IClient> _clients = new List<IClient>();

        public RenaultFactory(string factoryName)
        {
            FactoryName = factoryName;
        }

        string FactoryName { get; }

        public override ICar CreateCar(ToyotaModel toyotaModel) => throw new Exception("Cannot create Toyota model from Renault factory");

        public override ICar CreateCar(RenaultModel renaultModel)
        {
            Renault renault = new Renault(BrandModel.Renault, renaultModel);
            Notification notification = CreateNotification(renault);
            AddNotifications(notification);
            NotifyClient(notification);

            return renault;
        }

        public override string GetFactoryName() => FactoryName;

        public override void AddClient(IClient client) => _clients.Add(client);
        public override void RemoveClient(IClient client) => _clients.Remove(client);

        Notification CreateNotification(ICar car) => new Notification(car);

        void AddNotifications(Notification notification) => _notifications.Add(notification);

        void NotifyClient(Notification notification)
        {
            foreach (IClient client in _clients)
            {
                client.AddNotification(notification);
            }
        }
    }
}
