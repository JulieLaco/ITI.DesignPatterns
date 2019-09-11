using ITI.DesignPatterns.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Dwarf : Character
    {
        private int _drunkLevel;
        private int _drunkLimit = 20;
        private int _drunkDamage = 4;
        private int _normalDamage = 40;

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
