namespace Entities
{
    /// <summary>
    /// Credit Card Class
    /// [Id : 1,2,3] 
    /// [Title : American Express, Platinium Card, Gold Card, Regular Card] 
    /// [Limit : 1000, 500, 250, 100] 
    /// [Charge : 10, 5, 2.5, 1]
    /// </summary>
    public class CreditCard
    {
        public int Id { get; set; }
        public string Title { get; set; } //Credit Card Name
        public decimal Limit { get; set; } //Maximum Spending Limit
        public decimal Charge { get; set; } //Monthly Charge
    }
}