using Entities;
using NUnit.Framework;

namespace Test.NoPattern
{
    public class InterfaceDesignPatternTest
    {
        private readonly InterfaceDesignPattern.Demo interfaceDemo = new InterfaceDesignPattern.Demo();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AmericanExpressTest()
        {
            string result = interfaceDemo.Run(CreditCardTypeEnum.AmericanExpress);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }

        [Test]
        public void PlatiniumCreditCardTest()
        {
            string result = interfaceDemo.Run(CreditCardTypeEnum.Platinium);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }

        [Test]
        public void GoldCreditCardTest()
        {
            string result = interfaceDemo.Run(CreditCardTypeEnum.Gold);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }

        [Test]
        public void RegularCreditCardTest()
        {
            string result = interfaceDemo.Run(CreditCardTypeEnum.Regular);
            Assert.That(result, Is.Not.EqualTo("Not valid enum"));
        }
    }
}
