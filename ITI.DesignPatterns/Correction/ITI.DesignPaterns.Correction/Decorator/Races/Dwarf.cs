namespace ITI.DesignPatterns.Decorator.Races
{
    class Dwarf : Decorator
    {
        public Dwarf(Character character) 
            : base(character)
        {
        }

        public string DrinkBeer()
        {
            return "Burp !!!";
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " and I'm a proud Dwarf";
        }
    }
}
