using Microsoft.EntityFrameworkCore;

namespace Finance.Models
{
    [Keyless]
    public class ExpenseType
    {
        public enum TypeOfExpense {Food=0, Cafe=1, Entertainment=2, Subscription=3, Charity=4, Items=5, Other=6}
    }
}
