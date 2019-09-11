using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.DesignPatterns.AbstractFactory
{
    public interface ICharacter
    {
        string GetFirstName();
        string GetLastName();
        string Walk();
    }
}
