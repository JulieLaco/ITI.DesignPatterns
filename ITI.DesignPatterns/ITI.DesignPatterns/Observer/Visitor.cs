using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public class Visitor : IObserver
    {
        public List<Company> _companies = new List<Company>();

        public List<News> _notifications = new List<News>();

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
