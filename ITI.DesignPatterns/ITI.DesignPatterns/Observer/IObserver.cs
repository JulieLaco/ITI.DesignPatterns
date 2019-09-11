using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public interface IObserver
    {
        void AddNotification(News notification);
        void Subscription(Company company);
        void Unsubscribe(Company company);
    }
}
