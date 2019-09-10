namespace ITI.DesignPatterns.Decorator.Jobs
{
    class Smith : Decorator
    {
        public Smith(Character character) 
            : base(character)
        {
        }

        public string CreateSword()
        {
            return "You made a little sword !!!";
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " and my job is Smith";
        }
    }
}
