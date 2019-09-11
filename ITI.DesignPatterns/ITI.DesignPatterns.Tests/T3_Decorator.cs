using FluentAssertions;
using NUnit.Framework;

namespace ITI.DesignPatterns.Tests
{
    [TestFixture]
    class T3_Decorator
    {
        [Test]
        public void T1_create_a_human_character_with_a_Name()
        {
            var character = new Human(0) { Name = "Bill" };
            character.Name.Should().Be("Bill");
        }

        [Test]
        public void T2_create_a_human_character_with_a_Name_and_Warrior_Class()
        {
            var character = new Human(0) { Name = "Bill" };
            var characterClass = new Warrior(character);
            
            characterClass.Name.Should().Be("Bill");
            characterClass.Should().BeOfType<Warrior>();
        }

        [Test]
        public void T3_create_a_dwarf_character_with_a_Name()
        {
            var character = new Dwarf(0) { Name = "Gonar" };
            character.Name.Should().Be("Gonar");
        }

        [Test]
        public void T4_create_a_dwarf_character_with_a_Name_and_Wizard_Class()
        {
            var character = new Dwarf(0) { Name = "Gonar" };
            var characterClass = new Wizard(character);

            characterClass.Name.Should().Be("Gonar");
            characterClass.Should().BeOfType<Wizard>();
        }

        [Test]
        public void T5_create_a_human_character_with_a_Name_and_Wizard_Class_and_Warrior_Class()
        {
            var character = new Dwarf(0) { Name = "Gonar" };
            var characterClass1 = new Warrior(character);
            var characterClass2 = new Wizard(characterClass1);

            characterClass1.Should().BeOfType<Warrior>();
            characterClass2.Should().BeOfType<Wizard>();

            characterClass1.Name.Should().Be("Gonar");
            characterClass2.Name.Should().Be("Gonar");
        }

        [Test]
        public void T6_a_human_character_with_Wizard_Class_Should_Do_Magical_Damage()
        {
            var character = new Human(0) { Name = "Bill" };
            var characterClass = new Wizard(character);

            var baseDamage = character.Attack();
            var damages = characterClass.Attack();

            characterClass.Name.Should().Be("Bill");
            characterClass.Should().BeOfType<Wizard>();

            damages.Quantity.Should().Be(baseDamage.Quantity + characterClass.WizardDamages.Quantity);
            damages.Type.Should().Be(characterClass.WizardDamages.Type);
        }
    }
}
