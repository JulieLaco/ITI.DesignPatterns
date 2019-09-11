using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Human : Character
    {
        private int _fear;
        private int _fearLimit = 20;

        public Human(int courage)
        {
            _fear = courage;
        }
        
        public override Damages Attack()
        {
            if(_fear > _fearLimit)
            {
                return new Damages() { Quantity = 0, Type = DamageTypes.Physical };
                
            }

            return new Damages() { Quantity = 5 , Type = DamageTypes.Physical };
        }
    }
}
