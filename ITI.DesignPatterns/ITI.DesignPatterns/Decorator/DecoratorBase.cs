using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator
{
    public abstract class DecoratorBase : Character
    {
        protected Character character;

        public DecoratorBase(Character character)
        {
            this.character = character;
        }

        public override Damages Attack()
        {
            return character.Attack();
        }
    }
}
