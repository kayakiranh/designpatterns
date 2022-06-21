namespace FactoryMethodDesignPattern
{
    public interface ICreditCardService
    {
        string GetCreditCard();
        decimal GetLimit();
        decimal GetMonthlyCharge();
    }
}