using ITI.DesignPatterns.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Human : Character
    {
        public Human(int courage)
        {
            throw new NotImplementedException();
        }

        public int FearDamage { get { throw new NotImplementedException(); } }
        public int NormalDamage { get { throw new NotImplementedException(); } }

        public override Damages Attack()
        {
            throw new NotImplementedException();
        }
    }
}
