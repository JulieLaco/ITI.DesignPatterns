using ITI.DesignPatterns.Correction.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Correction.Decorator.Races
{
    public class Dwarf : Character
    {
        private int _drunkLevel;
        private int _drunkLimit = 20;
        private int _drunkDamage = 4;
        private int _normalDamage = 40;

        public Dwarf(int drunkLevel)
        {
            _drunkLevel = drunkLevel;
        }

        public int DrunkDamage { get { return _drunkDamage; } }
        public int NormalDamage { get { return _normalDamage; } }

        public override Damages Attack()
        {
            if (_drunkLevel > _drunkLimit)
            {
                return new Damages() { Quantity = _drunkDamage, Type = DamageTypes.Physical };

            }

            return new Damages() { Quantity = _normalDamage, Type = DamageTypes.Physical };
        }
    }
}
