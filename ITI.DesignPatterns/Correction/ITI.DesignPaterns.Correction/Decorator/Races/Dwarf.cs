﻿using ITI.DesignPatterns.Correction.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Correction.Decorator.Races
{
    public class Dwarf : Character
    {
        private int _drunkLevel;
        private int _drunkLimit = 20;

        public Dwarf(int drunkLevel) 
        {
            _drunkLevel = drunkLevel;
        }

        public override Damages Attack()
        {
            if (_drunkLevel > _drunkLimit)
            {
                return new Damages() { Quantity = 4, Type = DamageTypes.Physical };

            }

            return new Damages() { Quantity = 40, Type = DamageTypes.Physical };
        }
    }
}
