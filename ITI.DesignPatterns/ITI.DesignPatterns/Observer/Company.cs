using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public class Company
    {
        readonly List<IObserver> _companyObserver;
        readonly List<News> _newsList;

        public Company(string name)
        {
            throw new NotImplementedException();
        }

        public string GetName { get; }

        public List<IObserver> CompagniesObservers { get; }

        public List<News> News { get; }

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
