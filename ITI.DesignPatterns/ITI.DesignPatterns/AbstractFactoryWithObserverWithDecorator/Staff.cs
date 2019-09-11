using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public class Staff : IClient
    {
        public Staff(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public string FirstName { get; }

        public string LastName { get; }

        public void AddNotification(Notification notification) => throw new NotImplementedException();

        public List<Notification> GetNotifications() => throw new NotImplementedException();

        public void Subscription(CarFactory carFactory)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(CarFactory carFactory)
        {
            throw new NotImplementedException();
        }
    }
}
