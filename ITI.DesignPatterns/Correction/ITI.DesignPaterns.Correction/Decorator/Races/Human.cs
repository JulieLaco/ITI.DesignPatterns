using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Human : Character
    {
        private readonly int _fear;
        private readonly int _fearLimit = 20;
        private readonly int _fearDamage = 0;
        private readonly int _normalDamage = 20;

        public Human(int courage)
        {
            _fear = courage;
        }

        public int FearDamage { get { return _fearDamage; } }
        public int NormalDamage { get { return _normalDamage; } }

        public override Damages Attack()
        {
            if(_fear > _fearLimit)
            {
                return new Damages() { Quantity = _fearDamage, Type = DamageTypes.Miss };
                
            }

            return new Damages() { Quantity = _normalDamage, Type = DamageTypes.Physical };
        }
    }
}
