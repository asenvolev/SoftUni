using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeLosesDurabilityAfterAtack()
    {
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(10, 10);

        axe.Attack(dummy);

        Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
    }
    [Test]
    public void AttackWithABrokenAxeShouldThrowException()
    {
        Axe axe = new Axe(10, 0);
        Dummy dummy = new Dummy(10, 10);

        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}