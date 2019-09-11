using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Classes
{
    public class Warrior : DecoratorBase
    {
        private readonly Damages _warriorDamage = new Damages { Quantity = 20, Type = DamageTypes.Physical };

        public Warrior(Character character)
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
