using ITI.DesignPatterns.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Dwarf : Character
    {
        public Dwarf(int drunkLevel) 
        {
            throw new NotImplementedException();
        }

        public int DrunkDamage { get { throw new NotImplementedException(); } }
        public int NormalDamage { get { throw new NotImplementedException(); } }

        public override Damages Attack()
        {
            throw new NotImplementedException();
        }
    }
}
