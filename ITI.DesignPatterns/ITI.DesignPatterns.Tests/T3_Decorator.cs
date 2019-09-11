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
            var human = new Human(0) { Name = "Bill" };
            var attack = human.Attack();

            human.Name.Should().Be("Bill");

            attack.Quantity.Should().Be(human.NormalDamage);
            attack.Type.Should().Be(DamageTypes.Physical);
        }

        [Test]
        public void T2_create_a_human_character_with_a_Name_and_Warrior_Class()
        {
            var human = new Human(0) { Name = "Bill" };
            var warrior = new Warrior(human);

            var attack = warrior.Attack();

            warrior.Name.Should().Be("Bill");
            attack.Quantity.Should().Be(human.NormalDamage + warrior.Damages.Quantity);
            attack.Type.Should().Be(DamageTypes.Physical);
        }

        [Test]
        public void T3_create_a_dwarf_character_with_a_Name()
        {
            var dwarf = new Dwarf(0) { Name = "Gonar" };
            var attack = dwarf.Attack();
            dwarf.Name.Should().Be("Gonar");
            attack.Quantity.Should().Be(dwarf.NormalDamage);
            attack.Type.Should().Be(DamageTypes.Physical);
        }

        [Test]
        public void T4_create_a_dwarf_character_with_a_Name_and_Wizard_Class()
        {
            var dwarf = new Dwarf(0) { Name = "Gonar" };
            var wizard = new Wizard(dwarf);

            var attack = wizard.Attack();
            wizard.Name.Should().Be("Gonar");
            attack.Quantity.Should().Be(dwarf.NormalDamage + wizard.Damages.Quantity);
            attack.Type.Should().Be(DamageTypes.Magical);
        }

        [Test]
        public void T5_create_a_human_character_with_a_Name_and_Wizard_Class_and_Warrior_Class()
        {
            var dwarf = new Dwarf(0) { Name = "Gonar" };
            var warrior = new Warrior(dwarf);
            var wizardWarrior = new Wizard(warrior);

            warrior.Should().BeOfType<Warrior>();
            wizardWarrior.Should().BeOfType<Wizard>();

            var attack = wizardWarrior.Attack();
            wizardWarrior.Name.Should().Be("Gonar");
            attack.Quantity.Should().Be(dwarf.NormalDamage + warrior.Damages.Quantity + wizardWarrior.Damages.Quantity);
            attack.Type.Should().Be(DamageTypes.Magical);
        }
        
        [Test]
        public void T6_a_feared_human_character_doesnt_make_damage()
        {
            var character = new Human(50) { Name = "Bill" };
            var characterClass = new Wizard(character);

            var damages = characterClass.Attack();

            character.Name.Should().Be("Bill");
            characterClass.Should().BeOfType<Wizard>();

            damages.Quantity.Should().Be(0);
            damages.Type.Should().Be(DamageTypes.Miss);
        }

        [Test]
        public void T7_a_drunk_dwarf_character_make_less_damage()
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
