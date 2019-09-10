namespace ITI.DesignPatterns.Decorator.Races
{
    class Human : Decorator
    {
        public Human(Character character) 
            : base(character)
        {
        }

        public string Ride()
        {
            return "Horses rocks !!!";
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " and I'm a brave Human";
        }
    }
}
