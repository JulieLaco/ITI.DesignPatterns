using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.ObserverMethod
{
    public class Company
    {
        readonly public List<IObserver> _companyObserver;
        readonly public List<News> _newsList;

        public Company(string name)
        {
            throw new NotImplementedException();
        }

        public string GetName { get; }

        public void AddSubscriber(IObserver newObserver)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubscriber(IObserver oldObserver)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllSubscribers()
        {
            throw new NotImplementedException();
        }

        void NotifySubscribers(News notification)
        {
            throw new NotImplementedException();
        }

        public void CreateNews(string title, string message)
        {
            throw new NotImplementedException();
        }

        void AddNews(News news) => throw new NotImplementedException();
    }
}
