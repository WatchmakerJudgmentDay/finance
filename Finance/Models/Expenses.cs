namespace Finance.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string? Comments { get; set; }
        public decimal Price { get; set; }
        public DateTime TimeOfExpense { get; set; }
        public BankType Bank { get; set; }
        public ExpenseType TypeOfExpense { get; set; }

    }
}
