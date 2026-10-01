using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finance.Models
{
    [Keyless]
    public class BankType
    {

        public enum Bank : int {Debet = 0, Credit = 1, Cash = 2}
       

    }
}
