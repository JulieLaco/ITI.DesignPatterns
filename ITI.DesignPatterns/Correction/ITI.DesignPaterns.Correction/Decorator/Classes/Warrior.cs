namespace ITI.DesignPatterns.Decorator.Classes
{
    class Warrior : Decorator
    {
        public Warrior(Character character)
            : base(character)
        {

        }

        public string UseSword()
        {
            return "Slash !!!";
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " and my class is Warrior";
        }
    }
}
