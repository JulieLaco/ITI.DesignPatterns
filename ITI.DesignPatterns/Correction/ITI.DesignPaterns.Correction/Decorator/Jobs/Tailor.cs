namespace ITI.DesignPatterns.Decorator.Jobs
{
    class Tailor : Decorator
    {
        public Tailor(Character character)
            : base(character)
        {
        }

        public string CreateBag()
        {
            return "You made a little bag !!!";
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " and my job is Tailor";
        }
    }
}
