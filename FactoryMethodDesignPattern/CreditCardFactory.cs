using Entities;

namespace FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCardService GenerateCreditCard();
        public ICreditCardService CreateCreditCard()
        {
            return this.GenerateCreditCard();
        }
    }
}