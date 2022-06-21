namespace InterfaceDesignPattern.Cards
{
    public class AmericanExpress : ICreditCardService
    {
        public string GetCreditCard()
        {
            return "American Express";
        }

        public decimal GetLimit()
        {
            return (decimal)1000;
        }

        public decimal GetMonthlyCharge()
        {
            return (decimal)10;
        }
    }
}