using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactoryMethod
{
    public interface ICharacter
    {
        string GetFirstName();
        string GetLastName();
        string Walk();
    }
}
