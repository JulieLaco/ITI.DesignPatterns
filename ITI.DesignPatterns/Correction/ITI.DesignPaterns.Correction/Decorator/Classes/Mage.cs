namespace ITI.DesignPatterns.Decorator.Classes
{
    class Wizard : Decorator
    {
        public Wizard(Character character)
            :base(character)
        {

        }

        public string UseFireSpell()
        {
            return "Fire !!!";
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " and my class is Mage";
        }
    }
}
