using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Classes
{
    public class Wizard : DecoratorBase
    {
        private readonly Damages _wizardDamage;

        public Wizard(Character character)
            : base(character)
        {

        }

        public Damages Damages { get { throw new System.NotImplementedException(); } }

        public override Damages Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
