using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.Observer
{
    public class News
    {
        internal News(string title, string message, Company company)
        {
            Title = title;
            Message = message;
            Company = company;
        }

        public string Title { get; }
        public string Message { get; }

        public Company Company { get; }

    }
}
