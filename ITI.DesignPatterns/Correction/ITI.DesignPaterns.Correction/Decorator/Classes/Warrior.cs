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

        public Damages Damages { get { return _warriorDamage; } }

        public override Damages Attack()
        {
            var baseDamage = base.Attack();

            if (baseDamage.Type != DamageTypes.Miss)
            {
                return new Damages() { Quantity = baseDamage.Quantity + _warriorDamage.Quantity, Type = _warriorDamage.Type };
            }
            else
            {
                return new Damages() { Quantity = 0, Type = DamageTypes.Miss };
            }
        }
    }
}
