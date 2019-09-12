using ITI.DesignPatterns.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Dwarf : Character
    {
        public Dwarf(int drunkLevel) 
        {
            
        }

        public int DrunkDamage { get { throw new System.NotImplementedException(); } }
        public int NormalDamage { get { throw new System.NotImplementedException(); } }

        public override Damages Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
