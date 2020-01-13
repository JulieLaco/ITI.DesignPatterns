using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public class Company
    {
        readonly List<IObserver> _companyObserver = new List<IObserver>();
        readonly List<News> _newsList = new List<News>();

        public Company(string name)
        {
            GetName = name;
        }

        public string GetName { get; }

        public List<IObserver> CompagniesObservers { get { return _companyObserver; } }

        public List<News> News { get { return _newsList; } }

        public void AddSubscriber(IObserver newObserver)
        {
            _companyObserver.Add(newObserver);
        }

        public void RemoveSubscriber(IObserver oldObserver)
        {
            _companyObserver.Remove(oldObserver);
        }

        public void RemoveAllSubscribers()
        {
            _companyObserver.Clear();
        }

        void NotifySubscribers(News notification)
        {
            foreach(IObserver sub in _companyObserver)
            {
                sub.AddNotification(notification);
            }
        }

        public void CreateNews(string title, string message)
        {
            News n = new News(title, message, this);
            AddNews(n);
            NotifySubscribers(n);
        }

        void AddNews(News news) => _newsList.Add(news);
    }
}
