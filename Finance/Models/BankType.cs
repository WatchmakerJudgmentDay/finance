using System.ComponentModel.DataAnnotations.Schema;

namespace Finance.Models
{
    public class BankType
    {

        public enum Bank : int {Debet = 0, Credit = 1, Cash = 2}
       

    }
}
