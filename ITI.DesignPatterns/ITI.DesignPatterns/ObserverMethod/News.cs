using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.ObserverMethod
{
    public class News
    {
        internal News(string title, string message, Company company)
        {
            throw new NotImplementedException();
        }

        public string Title { get; }
        public string Message { get; }

        public Company Company { get; }

    }
}
