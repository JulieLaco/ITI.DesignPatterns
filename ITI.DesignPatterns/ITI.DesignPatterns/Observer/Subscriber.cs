using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public class Subscriber : IObserver
    {
        readonly List<Company> _companies = new List<Company>();
        readonly List<News> _notifications = new List<News>();

        public Subscriber(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public List<Company> Companies { get; }

        public List<News> Notifications { get; }

        public string GetLastName { get; }

        public string GetFirstName { get; }

        public void AddNotification(News notification) => throw new NotImplementedException();

        void AddCompany(Company company) => throw new NotImplementedException();

        void RemoveCompany(Company company) => throw new NotImplementedException();

        public void Subscription(Company company)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(Company company)
        {
            throw new NotImplementedException();
        }

    }
}
