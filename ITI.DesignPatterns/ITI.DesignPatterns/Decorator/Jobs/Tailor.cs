using ITI.DesignPatterns.Decorator;
using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Jobs
{
    public class Tailor : DecoratorBase
    {
        public Tailor(Character character)
            : base(character)
        {
        }

        //public string CreateBag()
        //{
        //    return "You made a little bag !!!";
        //}

        public override Damages Attack()
        {
            var baseDamage = base.Attack();
            var newDamage = new Damages() { Quantity = baseDamage.Quantity - 5, Type = DamageTypes.Physical };
            return newDamage;
        }
    }
}
