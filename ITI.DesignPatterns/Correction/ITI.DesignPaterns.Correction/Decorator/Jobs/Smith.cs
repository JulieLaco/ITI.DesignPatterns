using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Jobs
{
    public class Smith : DecoratorBase
    {
        public Smith(Character character) 
            : base(character)
        {
        }

        //public string CreateSword()
        //{
        //    return "You made a little sword !!!";
        //}

        public override Damages Attack()
        {
            var baseDamage = base.Attack();
            var newDamage = new Damages() { Quantity = baseDamage.Quantity + 5, Type = DamageTypes.Physical };
            return newDamage;
        }
    }
}
