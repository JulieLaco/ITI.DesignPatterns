using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Visitor : IClient
    {
        readonly List<Notification> _notifications = new List<Notification>();
        readonly List<CarFactory> _carFactory = new List<CarFactory>();

        public void AddNotification(Notification notification) => _notifications.Add(notification);

        public List<Notification> GetNotifications() => _notifications;

        void AddCarCompany(CarFactory carFactoryCompany) => _carFactory.Add(carFactoryCompany);
        void RemoveCarCompany(CarFactory carFactoryCompany) => _carFactory.Remove(carFactoryCompany);

        public void Subscription(CarFactory carFactory)
        {
            if (_carFactory.Contains(carFactory)) throw new Exception("Already subscribe !");

            AddCarCompany(carFactory);
            carFactory.AddClient(this);
        }

        public void Unsubscribe(CarFactory carFactory)
        {
            if(!_carFactory.Contains(carFactory)) throw new Exception("Not subscribe !");

            RemoveCarCompany(carFactory);
            carFactory.RemoveClient(this);
        }
    }
}
