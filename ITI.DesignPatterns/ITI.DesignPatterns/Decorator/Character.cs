using ITI.DesignPatterns.Decorator.Damage;

namespace ITI.DesignPatterns.Decorator
{
    public abstract class Character
    {
        public virtual string Name { get; set; }

        public abstract Damages Attack();
    }
}
