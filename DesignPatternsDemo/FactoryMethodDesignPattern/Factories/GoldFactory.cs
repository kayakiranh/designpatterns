using FactoryMethodDesignPattern.Cards;
namespace FactoryMethodDesignPattern.Factories
{
    public class GoldFactory : CreditCardFactory
    {
        protected override ICreditCardService GenerateCreditCard()
        {
            ICreditCardService creditCardService = new Gold();
            return creditCardService;
        }
    }
}