using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public string? Description { get; set; }
        public decimal Amount { get; set; }

        public string? Category { get; set; }
        public DateTime Date = DateTime.Now;

        public Transaction()
        {
            
        }
    }
}
