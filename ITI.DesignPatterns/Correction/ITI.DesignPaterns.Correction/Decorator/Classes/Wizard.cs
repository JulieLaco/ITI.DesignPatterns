using ITI.DesignPatterns.Correction.Decorator.Damage;

namespace ITI.DesignPatterns.Correction.Decorator.Classes
{
    public class Wizard : DecoratorBase
    {
        private readonly Damages _wizardDamage = new Damages { Quantity = 20, Type = DamageTypes.Magical };

        public Wizard(Character character)
            :base(character)
        {

        }

        public Damages WizardDamages { get { return _wizardDamage; } }

        public override Damages Attack()
        {
            var baseDamage = base.Attack();

            if (baseDamage.Type != DamageTypes.Miss)
            {
                return new Damages() { Quantity = baseDamage.Quantity + _wizardDamage.Quantity, Type = _wizardDamage.Type };
            }
            else
            {
                return new Damages() { Quantity = 0, Type = DamageTypes.Miss };
            }
        }
    }
}
