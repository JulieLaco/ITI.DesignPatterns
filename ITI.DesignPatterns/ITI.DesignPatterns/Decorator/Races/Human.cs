using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator.Races
{
    public class Human : Character
    {
        private int _fear;
        private int _fearLimit = 20;
        private int _fearDamage = 0;
        private int _normalDamage = 20;

        public Human(int courage)
        {
            _fear = courage;
        }

        public int FearDamage { get { throw new System.NotImplementedException(); } }
        public int NormalDamage { get { throw new System.NotImplementedException(); } }

        public override Damages Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
