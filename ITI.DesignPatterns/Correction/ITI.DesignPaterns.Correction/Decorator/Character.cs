namespace ITI.DesignPatterns.Decorator
{
    abstract class Character
    {
        public string Name { get; set; }

        public abstract string DisplayInfo();
    }
}
