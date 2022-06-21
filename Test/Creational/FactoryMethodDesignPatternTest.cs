using Entities;
using NUnit.Framework;

namespace Test.Creational
{
    public class FactoryMethodDesignPatternTest
    {
        private readonly FactoryMethodDesignPattern.Demo factoryMethodDemo = new FactoryMethodDesignPattern.Demo();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AmericanExpressTest()
        {
            string result = factoryMethodDemo.Run(CreditCardTypeEnum.AmericanExpress);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }

        [Test]
        public void PlatiniumCreditCardTest()
        {
            string result = factoryMethodDemo.Run(CreditCardTypeEnum.Platinium);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }

        [Test]
        public void GoldCreditCardTest()
        {
            string result = factoryMethodDemo.Run(CreditCardTypeEnum.Gold);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }

        [Test]
        public void RegularCreditCardTest()
        {
            string result = factoryMethodDemo.Run(CreditCardTypeEnum.Regular);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }
    }
}