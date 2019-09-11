using ITI.DesignPatterns.Correction.Decorator.Damage;

namespace ITI.DesignPatterns.Correction.Decorator
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
