using FluentAssertions;
//using ITI.DesignPatterns.FactoryMethod2;
using ITI.DesignPaterns.Correction.FactoryMethod;
using NUnit.Framework;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    public class T1_FactoryMethod
    {
        [Test]
        public void T1_create_character_with_FirstName_And_LastName()
        {
            CharacterFactory characterFactory = new CharacterFactory();

            {
                Character defaultCharacter = characterFactory.CreateDefaultCharacter("David", "Mazz");
                defaultCharacter.GetLastName().Should().Be("Mazz");
                defaultCharacter.GetFirstName().Should().Be("David");
                defaultCharacter.GetCharacterClass().Should().Be("Guerrier");
                defaultCharacter.GetCharacterType().Should().Be("Nain");
            }

            {
                Character gnomeLepreux = characterFactory.CreateGnomeLepreux("Achmed", "The dead terrorist");
                gnomeLepreux.GetLastName().Should().Be("The dead terrorist");
                gnomeLepreux.GetFirstName().Should().Be("Achmed");
                gnomeLepreux.GetCharacterClass().Should().Be("Suicide bomber");
                gnomeLepreux.GetCharacterType().Should().Be("Gnome Lepreux");
            }

            {
                Character rhumano�de = characterFactory.CreateRhumano�de("Bob", "le robot ivre");
                rhumano�de.GetLastName().Should().Be("le robot ivre");
                rhumano�de.GetFirstName().Should().Be("Bob");
                rhumano�de.GetCharacterClass().Should().Be("Alcoolique");
                rhumano�de.GetCharacterType().Should().Be("Rhumano�de");
            }
        }

        [Test]
        public void T2_get_heroes_stuff()
        {
            CharacterFactory characterFactory = new CharacterFactory();

            {
                Character defaultCharacter = characterFactory.CreateDefaultCharacter("Gohn", "Dead");
                defaultCharacter.GetStuff().Should().NotBeNull();
                defaultCharacter.GetStuff().Count.Should().Be(10);
            }

            {
                Character rhumano�de = characterFactory.CreateRhumano�de("Gan", "Tsuki");
                rhumano�de.GetStuff().Should().NotBeNull();
                rhumano�de.GetStuff()[0].Should().Be("alcool");
            }
        }

        //[Test]
        //public void T3test()
        //{
        //    var factory = new Character().ExecuteCreation(CharacterType.Human, "Sir", "Arthur");
        //    factory.Walk().Should().Be("je marche !");
        //}
    }
}
