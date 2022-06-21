using FactoryMethodDesignPattern.Cards;

namespace FactoryMethodDesignPattern.Factories
{
    public class PlatiniumFactory : CreditCardFactory
    {
        protected override ICreditCardService GenerateCreditCard()
        {
            ICreditCardService creditCardService = new Platinium();
            return creditCardService;
        }
    }
}