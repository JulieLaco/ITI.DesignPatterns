﻿using ITI.DesignPatterns.Correction.Decorator.Damage;

namespace ITI.DesignPatterns.Correction.Decorator
{
    public abstract class Character
    {
        public string Name { get; set; }

        public abstract Damages Attack();
    }
}