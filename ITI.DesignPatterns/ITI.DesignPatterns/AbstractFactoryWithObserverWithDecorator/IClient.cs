using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator
{
    public interface IClient
    {
        List<Notification> GetNotifications();
        void AddNotification(Notification notification);
        void Subscription(CarFactory carFactory);
        void Unsubscribe(CarFactory carFactory);
    }
}
