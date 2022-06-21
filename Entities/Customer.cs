namespace Entities
{
    /// <summary>
    /// Customer Class
    /// [Full Name : [Hüseyin, Mine, Tülay, Nebati]
    /// [IsBlackList : false, false, false, True]
    /// [FinancialScore : 70, 90, 40, 20]
    /// [Salary : 15000, 10000, 4000, 20000]
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } //First Name
        public bool IsBlackList { get; set; } = false; //Black list status
        public int FinancialScore { get; set; } = 0; //Financial score 0-100. High is better.
        public decimal Salary { get; set; } //Monthly salary. High is better.
    }
}