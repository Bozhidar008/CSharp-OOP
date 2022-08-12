namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void SetUp()
        {
            this.arena = new Arena();
        }

        [Test]
        public void Ctor_InitializeWarriors()
        {
            Assert.That(this.arena.Warriors, Is.Not.Null);
        }

        [Test]
        public void Count_IsZero_WhenArenaIsEmpty()
        {
            Assert.That(this.arena.Count, Is.EqualTo(0));
        }

        [Test]
        public void Enroll_ThrowException_WhenWarriorAlreadyExist()
        {
            string name = "Warrior";
            this.arena.Enroll(new Warrior(name, 50, 100));
            Assert.Throws<InvalidOperationException>(()=>arena.Enroll(new Warrior(name, 40, 80)));
        }

        [Test]
        public void Enroll_IncreaseArenaCount()
        {
            this.arena.Enroll(new Warrior("warrior1", 50, 100));
            this.arena.Enroll(new Warrior("warrior2", 60, 130));
            int expectedCount = 2;

            Assert.That(this.arena.Count, Is.EqualTo((int)expectedCount));
        }

        [Test]
        public void Enroll_AddWarriorToWarriors()
        {
            Warrior warrior = new Warrior("warrior", 50, 100);
            this.arena.Enroll(warrior);
            Assert.That(this.arena.Warriors.Count, Is.EqualTo(1));
            Assert.That(this.arena.Warriors.Any(w=>w.Name == "warrior"), Is.True);
        }

        [Test]
        [TestCase("Attacker","Attacker", "Defender")]
        [TestCase("Defender","Attacker", "Defender")]
        [TestCase("Warrior","Attacker", "Defender")]
        public void Fight_ThrowException_WhenWarriorNameIsNotValid(string warriorName, string attackerName, string defenderName)
        {
            this.arena.Enroll(new Warrior(warriorName, 40, 40));
            Assert.Throws<InvalidOperationException>(()=>this.arena.Fight(attackerName, defenderName));
        }

        [Test]
        public void Fight_BothWarriorsLoseHp()
        {
            int initialHp = 100;
            Warrior attacker = new Warrior("Attacker", 60, 100);
            Warrior defender = new Warrior("Defender", 40, 100);
            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            this.arena.Fight(attacker.Name, defender.Name);

            Assert.That(attacker.HP, Is.EqualTo(initialHp - defender.Damage));
            Assert.That(defender.HP, Is.EqualTo(initialHp - attacker.Damage));
        }
    }
}
