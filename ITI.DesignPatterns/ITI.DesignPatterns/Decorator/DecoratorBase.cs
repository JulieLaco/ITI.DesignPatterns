using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator
{
    public abstract class DecoratorBase : Character
    {
        protected Character _character;

        public DecoratorBase(Character character)
        {
            _character = character;
        }

        public override Damages Attack()
        {
            return _character.Attack();
        }

        public override string Name
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}
