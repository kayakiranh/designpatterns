using FactoryMethodDesignPattern.Cards;

namespace FactoryMethodDesignPattern.Factories
{
    public class AmericanExpressFactory : CreditCardFactory
    {
        protected override ICreditCardService GenerateCreditCard()
        {
            ICreditCardService creditCardService = new AmericanExpress();
            return creditCardService;
        }
    }
}