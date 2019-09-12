using ITI.DesignPatterns.Decorator.Damage;
using System;

namespace ITI.DesignPatterns.Decorator
{
    public abstract class DecoratorBase : Character
    {
        protected Character _character;

        public DecoratorBase(Character character)
        {
            throw new NotImplementedException();
        }

        public override Damages Attack()
        {
            throw new NotImplementedException();
        }

        public override string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
