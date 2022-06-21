namespace FactoryMethodDesignPattern.Cards
{
    public class Platinium : ICreditCardService
    {
        public string GetCreditCard()
        {
            return "Platinium Card";
        }

        public decimal GetLimit()
        {
            return (decimal)500;
        }

        public decimal GetMonthlyCharge()
        {
            return (decimal)5;
        }
    }
}