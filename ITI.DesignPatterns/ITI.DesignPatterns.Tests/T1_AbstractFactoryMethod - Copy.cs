using FluentAssertions;
using ITI.DesignPatterns.AbstractFactoryMethod;
using NUnit.Framework;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    public class T1_AbstractFactoryMethod
    {
        [Test]
        public void T1_create_human_character()
        {
            Human human = new Human("Jedusor", "Tom");
            human.LastName.Should().Be("Jedusor");
            human.FirstName.Should().Be("Tom");
        }

        [Test]
        public void T2_create_human_by_factory()
        {
            HumanFactory humanFactory = new HumanFactory();
            ICharacter iCharacter = humanFactory.Create("Jedusor", "Tom");
            iCharacter.Walk().Should().Be("Je marche !");
            iCharacter.GetLastName().Should().Be("Jedusor");
            iCharacter.GetFirstName().Should().Be("Tom");
        }

        [Test]
        public void T3_create_factory() 
        {
            ICharacter character = new Factory().CreateCharacter(CharacterType.Human, "Sir", "Arthur");
            character.Walk().Should().Be("Je marche !");
        }
    }
}
