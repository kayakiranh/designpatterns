namespace FactoryMethodDesignPattern.Cards
{
    public class Regular : ICreditCardService
    {
        public string GetCreditCard()
        {
            return "Regular Card";
        }

        public decimal GetLimit()
        {
            return (decimal)100;
        }

        public decimal GetMonthlyCharge()
        {
            return (decimal)1;
        }
    }
}