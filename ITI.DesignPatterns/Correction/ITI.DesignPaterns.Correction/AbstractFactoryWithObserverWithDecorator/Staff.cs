using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Staff : IClient
    {
        List<Notification> _notifications = new List<Notification>();
        List<CarFactory> _carFactory = new List<CarFactory>();

        public Staff(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public void AddNotification(Notification notification) => _notifications.Add(notification);

        void AddCarCompany(CarFactory carFactoryCompany) => _carFactory.Add(carFactoryCompany);
        void RemoveCarCompany(CarFactory carFactoryCompany) => _carFactory.Remove(carFactoryCompany);


        public List<Notification> GetNotifications() => _notifications;

        public void Subscription(CarFactory carFactory)
        {
            if(_carFactory.Contains(carFactory)) throw new Exception("Already subscribe !");

            AddCarCompany(carFactory);
            carFactory.AddClient(this);
        }

        public void Unsubscribe(CarFactory carFactory)
        {
            if (!_carFactory.Contains(carFactory)) throw new Exception("Not subscribe !");

            RemoveCarCompany(carFactory);
            carFactory.RemoveClient(this);
        }
    }
}
