using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public class Subscriber : IObserver
    {
        public List<Company> _companies = new List<Company>();

        public List<News> _notifications = new List<News>();

        public Subscriber(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }   

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
