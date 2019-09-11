using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Subscriber : IClient
    {
        public Subscriber(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public void AddNotification(Notification notification) => throw new NotImplementedException();

        public void Subscription(CarFactory carFactory)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(CarFactory carFactory)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetNotifications() => throw new NotImplementedException();
    }
}
