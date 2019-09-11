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
            get { return _character.Name; }
            set { _character.Name = value; }
        }
    }
}
