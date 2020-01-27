using ITI.DesignPatterns.AbstractFactory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    public class PublicModelChecker
    {
        [Test]
        [Explicit]
        public void write_current_public_API_to_console_with_double_quotes()
        {
            Console.WriteLine(GetPublicAPI(typeof(CharacterFactory).Assembly).ToString().Replace("\"", "\"\""));
        }

        [Test]
        public void public_API_is_not_modified()
        {
            var model = XElement.Parse(@"<Assembly Name=""ITI.DesignPatterns"">
                                            <Types>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactory.Factory"">
                                                    <Member Type=""Method"" Name=""CreateCharacter"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactory.CharacterFactory"">
                                                    <Member Type=""Method"" Name=""Create"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactory.Human"">
                                                    <Member Type=""Property"" Name=""FirstName"" />
                                                    <Member Type=""Property"" Name=""LastName"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactory.HumanFactory"">
                                                    <Member Type=""Method"" Name=""Create"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactory.ICharacter"">
                                                    <Member Type=""Method"" Name=""GetFirstName"" />
                                                    <Member Type=""Method"" Name=""GetLastName"" />
                                                    <Member Type=""Method"" Name=""Walk"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Observer.Company"">
                                                    <Member Type=""Method"" Name=""AddSubscriber"" />
                                                    <Member Type=""Property"" Name=""GetName"" />
                                                    <Member Type=""Method"" Name=""RemoveSubscriber"" />
                                                    <Member Type=""Method"" Name=""RemoveAllSubscribers"" />
                                                    <Member Type=""Method"" Name=""NotifySubscribers"" />
                                                    <Member Type=""Method"" Name=""CreateNews"" />
                                                    <Member Type=""Method"" Name=""AddNews"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Observer.News"">
                                                    <Member Type=""Property"" Name=""Title"" />
                                                    <Member Type=""Property"" Name=""Message"" />
                                                    <Member Type=""Property"" Name=""Company"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Observer.Subscriber"">
                                                    <Member Type=""Property"" Name=""GetLastName"" />
                                                    <Member Type=""Property"" Name=""GetFirstName"" />
                                                    <Member Type=""Method"" Name=""AddNotification"" />
                                                    <Member Type=""Method"" Name=""AddCompany"" />
                                                    <Member Type=""Method"" Name=""RemoveCompany"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Observer.Visitor"">
                                                    <Member Type=""Method"" Name=""AddNotification"" />
                                                    <Member Type=""Method"" Name=""AddCompany"" />
                                                    <Member Type=""Method"" Name=""RemoveCompany"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Observer.IObserver"">
                                                    <Member Type=""Method"" Name=""AddNotification"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.Classes.Warrior"">
                                                    <Member Type=""Property"" Name=""Damages"" />
                                                    <Member Type=""Method"" Name=""Attack"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.Classes.Wizard"">
                                                    <Member Type=""Property"" Name=""Damages"" />
                                                    <Member Type=""Method"" Name=""Attack"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.Damage.Damages"">
                                                    <Member Type=""Property"" Name=""Quantity"" />
                                                    <Member Type=""Property"" Name=""Type"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.Races.Dwarf"">
                                                    <Member Type=""Property"" Name=""DrunkDamage"" />
                                                    <Member Type=""Property"" Name=""NormalDamage"" />
                                                    <Member Type=""Method"" Name=""Attack"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.Races.Human"">
                                                    <Member Type=""Property"" Name=""FearDamage"" />
                                                    <Member Type=""Property"" Name=""NormalDamage"" />
                                                    <Member Type=""Method"" Name=""Attack"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.Character"">
                                                    <Member Type=""Property"" Name=""Name"" />
                                                    <Member Type=""Method"" Name=""Attack"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.Decorator.DecoratorBase"">
                                                    <Member Type=""Property"" Name=""Name"" />
                                                    <Member Type=""Method"" Name=""Attack"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.CarFactory"">
                                                    <Member Type=""Method"" Name=""CreateCar"" />
                                                    <Member Type=""Method"" Name=""GetFactoryName"" />
                                                    <Member Type=""Method"" Name=""AddClient"" />
                                                    <Member Type=""Method"" Name=""RemoveClient"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.DecoratorBase"">
                                                    <Member Type=""Property"" Name=""GetMaxSpeed"" />
                                                    <Member Type=""Method"" Name=""Accelerate"" />
                                                    <Member Type=""Method"" Name=""GetBrandModel"" />
                                                    <Member Type=""Method"" Name=""GetModel"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Visitor"">
                                                    <Member Type=""Method"" Name=""AddNotification"" />
                                                    <Member Type=""Method"" Name=""GetNotifications"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Factory"">
                                                    <Member Type=""Property"" Name=""CarFactory"" />
                                                    <Member Type=""Method"" Name=""CreateToyota"" />
                                                    <Member Type=""Method"" Name=""CreateRenault"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Fins"">
                                                    <Member Type=""Property"" Name=""SpeedBoost"" />
                                                    <Member Type=""Method"" Name=""Accelerate"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Nitro"">
                                                    <Member Type=""Property"" Name=""SpeedBoost"" />
                                                    <Member Type=""Method"" Name=""Accelerate"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Notification"">
                                                    <Member Type=""Property"" Name=""Car"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Renault"">
                                                    <Member Type=""Property"" Name=""GetMaxSpeed"" />
                                                    <Member Type=""Method"" Name=""Accelerate"" />
                                                    <Member Type=""Method"" Name=""GetBrandModel"" />
                                                    <Member Type=""Method"" Name=""GetModel"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.RenaultFactory"">
                                                    <Member Type=""Method"" Name=""CreateCar"" />
                                                    <Member Type=""Method"" Name=""GetFactoryName"" />
                                                    <Member Type=""Method"" Name=""AddClient"" />
                                                    <Member Type=""Method"" Name=""RemoveClient"" />
                                                    <Member Type=""Method"" Name=""CreateNotification"" />
                                                    <Member Type=""Method"" Name=""AddNotifications"" />
                                                    <Member Type=""Method"" Name=""NotifyClient"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Staff"">
                                                    <Member Type=""Property"" Name=""FirstName"" />
                                                    <Member Type=""Property"" Name=""LastName"" />
                                                    <Member Type=""Method"" Name=""AddNotification"" />
                                                    <Member Type=""Method"" Name=""GetNotifications"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Toyota"">
                                                    <Member Type=""Property"" Name=""GetMaxSpeed"" />
                                                    <Member Type=""Method"" Name=""Accelerate"" />
                                                    <Member Type=""Method"" Name=""GetBrandModel"" />
                                                    <Member Type=""Method"" Name=""GetModel"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.ToyotaFactory"">
                                                    <Member Type=""Method"" Name=""CreateCar"" />
                                                    <Member Type=""Method"" Name=""GetFactoryName"" />
                                                    <Member Type=""Method"" Name=""AddClient"" />
                                                    <Member Type=""Method"" Name=""RemoveClient"" />
                                                    <Member Type=""Method"" Name=""CreateNotification"" />
                                                    <Member Type=""Method"" Name=""AddNotifications"" />
                                                    <Member Type=""Method"" Name=""NotifyClient"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.Subscriber"">
                                                    <Member Type=""Property"" Name=""FirstName"" />
                                                    <Member Type=""Property"" Name=""LastName"" />
                                                    <Member Type=""Method"" Name=""AddNotifications"" />
                                                    <Member Type=""Method"" Name=""GetNotifications"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.ICar"">
                                                    <Member Type=""Property"" Name=""GetMaxSpeed"" />
                                                    <Member Type=""Method"" Name=""GetBrandModel"" />
                                                    <Member Type=""Method"" Name=""GetModel"" />
                                                    <Member Type=""Method"" Name=""Accelerate"" />
                                                </Type>
                                                <Type Name=""ITI.DesignPatterns.AbstractFactoryWithObserverWithDecorator.IClient"">
                                                    <Member Type=""Method"" Name=""GetNotifications"" />
                                                    <Member Type=""Method"" Name=""AddNotification"" />
                                                    <Member Type=""Method"" Name=""Subscription"" />
                                                    <Member Type=""Method"" Name=""Unsubscribe"" />
                                                </Type>
                                            </Types>
                                         </Assembly>");
        }

        XElement GetPublicAPI(Assembly a)
        {
            return new XElement("Assembly",
                                  new XAttribute("Name", a.GetName().Name),
                                  new XElement("Types",
                                                AllNestedTypes(a.GetExportedTypes())
                                                 .OrderBy(t => t.FullName)
                                                 .Select(t => new XElement("Type",
                                                                               new XAttribute("Name", t.FullName),
                                                                               t.GetMembers()
                                                                                .OrderBy(m => m.Name)
                                                                                .Select(m => new XElement("Member",
                                                                                                            new XAttribute("Type", m.MemberType),
                                                                                                            new XAttribute("Name", m.Name)))))));
        }

        IEnumerable<Type> AllNestedTypes(IEnumerable<Type> types)
        {
            foreach (Type t in types)
            {
                yield return t;
                foreach (Type nestedType in AllNestedTypes(t.GetNestedTypes()))
                {
                    yield return nestedType;
                }
            }
        }
    }
}
