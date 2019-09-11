using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Subscriber : IClient
    {
        List<CarFactory> _carFactories = new List<CarFactory>();
        List<Notification> _notificationList = new List<Notification>();

        public Subscriber(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        void AddCarCompany(CarFactory carFactoryCompany) => _carFactories.Add(carFactoryCompany);     
        void RemoveCarCompany(CarFactory carFactoryCompany) => _carFactories.Remove(carFactoryCompany);

        public void AddNotification(Notification notification) => _notificationList.Add(notification);

        public void Subscription(CarFactory carFactory)
        {
            if(_carFactories.Contains(carFactory)) { throw new Exception("You already have a subscription to this company !"); }

            AddCarCompany(carFactory);
            carFactory.AddClient(this);
        }

        public void Unsubscribe(CarFactory carFactory)
        {
            if(!_carFactories.Contains(carFactory)) { throw new Exception("Not subscribe !"); }

            RemoveCarCompany(carFactory);
            carFactory.RemoveClient(this);
        }

        public List<Notification> GetNotifications() => _notificationList;
    }
}
