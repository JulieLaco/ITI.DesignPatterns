using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.FactoryMethod2
{
    public interface ICharacter
    {
        string GetFirstName();
        string GetLastName();
        string Walk();
    }
}
