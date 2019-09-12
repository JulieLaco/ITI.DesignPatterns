﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using ITI.DesignPatterns.Observer;
using NUnit.Framework;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    public class T2_ObserverMethod
    {
        [Test]
        public void T1_create_company_with_a_name()
        {
            Company company = new Company("GoodNews");
            company.GetName.Should().Be("GoodNews");
        }

        [Test]
        public void T2_create_news_with_a_title_and_message()
        {
            Company company = new Company("GoodNews");

            company.CreateNews("N1", "Message1");
            company.CreateNews("N2", "Message2");

            company._newsList.Should().NotBeNull();
            company._newsList[0].Title.Should().Be("N1");
            company._newsList[1].Message.Should().Be("Message2");
        }

        [Test]
        public void T3_create_a_subscriber_with_firstname_and_lastname()
        {
            Subscriber subscriber = new Subscriber("Olivier", "Spinelli");
            subscriber.GetFirstName.Should().Be("Olivier");
            subscriber.GetLastName.Should().Be("Spinelli");
        }

        [Test]
        public void T4_add_subscribers_to_the_company_mailing_list()
        {
            Company company = new Company("GoodNews");
            Subscriber subscriber = new Subscriber("Olivier", "Spinelli");

            subscriber.Subscription(company);
            subscriber._companies[0].GetName.Should().Be("GoodNews");
            company._companyObserver.Should().NotBeEmpty();
        }        

        [Test]
        public void T5_remove_subscribers_to_the_company_mailing_list()
        {
            Company company = new Company("GoodNews");
            Subscriber subscriber = new Subscriber("Olivier", "Spinelli");

            subscriber.Subscription(company);

            subscriber.Unsubscribe(company);
            subscriber._companies.Should().NotContain(company);
            company._companyObserver.Should().NotContain(subscriber);
        }

        [Test]
        public void T6_remove_all_subscribers_to_the_company_mailing_list()
        {
            Company company = new Company("GoodNews");
            Subscriber subscriber1 = new Subscriber("Olivier", "Spinelli");
            Subscriber subscriber2 = new Subscriber("Guillaume", "Elisabeth");
            Subscriber subscriber3 = new Subscriber("Yacine", "Chergui");

            subscriber1.Subscription(company);
            subscriber2.Subscription(company);
            subscriber3.Subscription(company);

            company._companyObserver.Should().Contain(subscriber3);

            company.RemoveAllSubscribers();
            company._companyObserver.Should().NotContain(subscriber3);
            company._companyObserver.Should().BeEmpty();
        }

        [Test]
        public void T7_notify_a_subscriber_when_creating_a_news()
        {
            Company company = new Company("GoodNews");
            Subscriber subscriber = new Subscriber("Olivier", "Spinelli");

            subscriber.Subscription(company);

            company.CreateNews("Achète toi des yeux", "Boulette !");

            subscriber._notifications[0].Title.Should().Be("Achète toi des yeux");
        }

        [Test]
        public void T8_multiple_subscriptions_to_different_car_companies_and_then_unsubscribing_of_one_subscriber_you_have_to_verify_that_notifications_are_sent_to_the_current_subscriber()
        {
            Company goodNews = new Company("GoodNews");

            Subscriber olivier = new Subscriber("Olivier", "Spinelli");
            olivier.Subscription(goodNews);

            goodNews.CreateNews("Title1", "Message1");

            olivier._notifications[0].Title.Should().Be("Title1");

            Company badNews = new Company("BadNews");
            olivier.Subscription(badNews);

            Visitor julie = new Visitor();
            julie.Subscription(badNews);

            badNews.CreateNews("Title2", "Message2");
            goodNews.CreateNews("Title3", "Message3");

            olivier._notifications[1].Company.Should().Be(badNews);
            olivier._notifications[2].Company.Should().Be(goodNews);

            julie._notifications[0].Company.Should().Be(badNews);

            julie._notifications.Count.Should().Be(1);
            olivier._notifications.Count.Should().Be(3);

            olivier.Unsubscribe(badNews);

            badNews.CreateNews("Title4", "Message4");

            julie._notifications[1].Company.Should().Be(badNews);

            julie._notifications.Count.Should().Be(2);
            olivier._notifications.Count.Should().Be(3);
        }
    }
}
