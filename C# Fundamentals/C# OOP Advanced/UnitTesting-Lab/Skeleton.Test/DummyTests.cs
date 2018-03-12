using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthIfAtacked()
    {
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(10, 10);

        axe.Attack(dummy);

        Assert.AreEqual(0, dummy.Health, "Axe Durability doesn't change after attack");
    }
    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(0, 10);

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

        Assert.AreEqual("Dummy is dead.", ex.Message);
    }
    [Test]
    public void AliveDummyCantGiveXp()
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(11, 10);
        axe.Attack(dummy);
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

        Assert.AreEqual("Target is not dead.", ex.Message);
    }
    [Test]
    public void DeadDummyCanGiveXp()
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);
        axe.Attack(dummy);

        Assert.AreEqual(10, dummy.GiveExperience());
    }
}