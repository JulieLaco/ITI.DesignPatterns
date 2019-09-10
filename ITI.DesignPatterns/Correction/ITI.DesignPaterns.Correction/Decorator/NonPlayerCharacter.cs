namespace ITI.DesignPatterns.Decorator
{
    class NonPlayerCharacter : Character
    {
        public string Speech { get; set; }

        public override string DisplayInfo()
        {
            return "I'm a non-player character, my name is " + base.Name;
        }
    }
}
