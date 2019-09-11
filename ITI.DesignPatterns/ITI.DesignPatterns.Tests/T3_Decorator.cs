using FluentAssertions;
using ITI.DesignPatterns.Decorator.Classes;
using ITI.DesignPatterns.Decorator.Damage;
using ITI.DesignPatterns.Decorator.Races;
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

            character.Name.Should().Be("Bill");
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

            character.Name.Should().Be("Gonar");
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

            character.Name.Should().Be("Gonar");
        }

        [Test]
        public void T6_a_human_character_with_Wizard_Class_Should_Do_Magical_Damage()
        {
            var character = new Human(0) { Name = "Bill" };
            var characterClass = new Wizard(character);

            var baseDamage = character.Attack();
            var damages = characterClass.Attack();

            character.Name.Should().Be("Bill");
            characterClass.Should().BeOfType<Wizard>();

            damages.Quantity.Should().Be(baseDamage.Quantity + characterClass.Damages.Quantity);
            damages.Type.Should().Be(DamageTypes.Magical);
        }

        [Test]
        public void T7_a_human_character_with_Warrior_Class_Should_Do_Physical_Damage()
        {
            var character = new Human(0) { Name = "Bill" };
            var characterClass = new Warrior(character);

            var baseDamage = character.Attack();
            var damages = characterClass.Attack();

            character.Name.Should().Be("Bill");
            characterClass.Should().BeOfType<Warrior>();

            damages.Quantity.Should().Be(baseDamage.Quantity + characterClass.Damages.Quantity);
            damages.Type.Should().Be(DamageTypes.Physical);
        }

        [Test]
        public void T8_a_feared_human_character_doesnt_make_damage()
        {
            var character = new Human(50) { Name = "Bill" };
            var characterClass = new Wizard(character);

            var baseDamage = character.Attack();
            var damages = characterClass.Attack();

            character.Name.Should().Be("Bill");
            characterClass.Should().BeOfType<Wizard>();

            damages.Quantity.Should().Be(0);
            damages.Type.Should().Be(DamageTypes.Miss);
        }

        [Test]
        public void T9_a_drunk_dwarf_character_make_less_damage()
        {
            var character = new Dwarf(50) { Name = "Gonar" };
            var characterClass = new Wizard(character);

            var baseDamage = character.Attack();
            var damages = characterClass.Attack();

            character.Name.Should().Be("Gonar");
            characterClass.Should().BeOfType<Wizard>();

            damages.Quantity.Should().Be(baseDamage.Quantity + characterClass.Damages.Quantity);
            damages.Type.Should().Be(characterClass.Damages.Type);
        }
    }
}
