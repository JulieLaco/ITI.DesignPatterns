using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.ObserverMethod
{
    public class Subscriber : IObserver
    {
        public List<Company> _companies = new List<Company>();

        public List<News> _notifications = new List<News>();

        public Subscriber(string firstName, string lastName)
        {
            GetFirstName = firstName;
            GetLastName = lastName;
        }   

        public string GetLastName { get; }

        public string GetFirstName { get; }

        public void AddNotification(News notification) => _notifications.Add(notification);

        void AddCompany(Company company) => _companies.Add(company);

        void RemoveCompany(Company company) => _companies.Remove(company);

        public void Subscription(Company company)
        {
            if (_companies.Contains(company))
            {
                throw new Exception("Already subscribe to this company !");
            }
            else
            {
                AddCompany(company);
                company.AddSubscriber(this);
            }
        }

        public void Unsubscribe(Company company)
        {
            if(_companies.Contains(company))
            {
                RemoveCompany(company);
                company.RemoveSubscriber(this);
            }
            else
            {
                throw new Exception("You're not subscribe to this company !");
            }
        }

    }
}
