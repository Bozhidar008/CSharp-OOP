namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        //private Warrior warrior;
        //[SetUp]
        //public void SetUp()
        //{
        //    this.warrior = new Warrior("Gosho", 50, 100);
        //}

        [Test]
        [TestCase("", 50, 100)]
        [TestCase(" ", 50, 100)]
        [TestCase(null, 50, 100)]
        [TestCase("Name", 0, 100)]
        [TestCase("Name", -10, 100)]
        [TestCase("Name", 50, -10)]
        public void Ctor_ThrowException_WhenDataIsInvalid(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(()=>new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(30,50)]
        [TestCase(15,50)]
        [TestCase(50,30)]
        [TestCase(50,15)]
        public void Attack_ThrowException_WhenHpIsLessThenMinimum(int attackerHp, int warriorHp)
        {
            Warrior attacker = new Warrior("Attacker", 50, attackerHp);
            Warrior warrior = new Warrior("Warrior", 10, warriorHp);

            Assert.Throws<InvalidOperationException>(()=>attacker.Attack(warrior)); 
        }

        [Test]
        public void Attack_ThrowException_WhenWarriorKillAttacker()
        {
            Warrior attacker = new Warrior("Attacker", 50, 100);
            Warrior warrior = new Warrior("Warrior", 101, 100);

            Assert.Throws<InvalidOperationException>(()=>attacker.Attack(warrior));
        }

        [Test]
        public void Attack_DecreaseHpForBoth()
        {
            Warrior attacker = new Warrior("Attacker", 30, 100);
            Warrior warrior = new Warrior("Warrior", 30, 100);

            attacker.Attack(warrior);

            Assert.That(attacker.HP, Is.EqualTo(100-warrior.Damage));
            Assert.That(warrior.HP, Is.EqualTo(100-attacker.Damage));
        }

        [Test]
        public void Attack_SetEnemyHpToZero_WhenAttackerDamageIsGreaterThenEnemyHp()
        {
            Warrior attacker = new Warrior("Attacker", 80, 100);
            Warrior warrior = new Warrior("Warrior", 30, 70);

            attacker.Attack(warrior);

            Assert.That(warrior.HP, Is.EqualTo(0));
        }
    }
}