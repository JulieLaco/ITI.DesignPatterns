using ITI.DesignPatterns.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Dwarf : Character
    {
        private readonly int _drunkLevel;
        private readonly int _drunkLimit = 20;
        private readonly int _drunkDamage = 4;
        private readonly int _normalDamage = 40;

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
