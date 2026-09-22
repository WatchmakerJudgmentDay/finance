using System.ComponentModel.DataAnnotations.Schema;

namespace Finance.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string? Comments { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeOfExpense { get; set; }
        [NotMapped]
        public BankType? Bank { get; set; }
        [NotMapped]
        public ExpenseType? TypeOfExpense { get; set; }

    }
}
