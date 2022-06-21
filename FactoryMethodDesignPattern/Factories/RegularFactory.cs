using FactoryMethodDesignPattern.Cards;

namespace FactoryMethodDesignPattern.Factories
{
    public class RegularFactory : CreditCardFactory
    {
        protected override ICreditCardService GenerateCreditCard()
        {
            ICreditCardService creditCardService = new Regular();
            return creditCardService;
        }
    }
}