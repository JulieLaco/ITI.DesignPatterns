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
        readonly List<Notification> _notifications = new List<Notification>();
        readonly List<IClient> _clients = new List<IClient>();

        public ToyotaFactory(string factoryName)
        {
            FactoryName = factoryName;
        }

        string FactoryName { get; }

        public override ICar CreateCar(ToyotaModel toyotaModel)
        {
            Toyota toyota = new Toyota(BrandModel.Toyota, toyotaModel);
            Notification notification = CreateNotification(toyota);
            AddNotifications(notification);
            NotifyClient(notification);

            return toyota;
        }

        public override ICar CreateCar(RenaultModel renaultModel) => throw new Exception("Cannot create a Renault model from Toyota factory");

        public override string GetFactoryName() => FactoryName;

        Notification CreateNotification(ICar car) => new Notification(car);

        void AddNotifications(Notification notification) => _notifications.Add(notification);

        void NotifyClient(Notification notification)
        {
            foreach (IClient client in _clients)
            {
                client.AddNotification(notification);
            }
        }

        public override void AddClient(IClient client) => _clients.Add(client);

        public override void RemoveClient(IClient client) => _clients.Remove(client);
    }
}
