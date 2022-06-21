namespace FactoryMethodDesignPattern.Cards
{
    public class Gold : ICreditCardService
    {
        public string GetCreditCard()
        {
            return "Gold Card";
        }

        public decimal GetLimit()
        {
            return (decimal)250;
        }

        public decimal GetMonthlyCharge()
        {
            return (decimal)2.5;
        }
    }
}