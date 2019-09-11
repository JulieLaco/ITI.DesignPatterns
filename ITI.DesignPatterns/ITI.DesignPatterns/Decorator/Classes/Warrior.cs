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

        public override Damages Attack()
        {
            var baseDamage = base.Attack();
            var newDamage = new Damages() { Quantity = baseDamage.Quantity + _warriorDamage.Quantity, Type = _warriorDamage.Type };
            return newDamage;
        }
    }
}
