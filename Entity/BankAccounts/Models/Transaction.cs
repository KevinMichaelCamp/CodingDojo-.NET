using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [RegularExpression(@"^\d*.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Amount must not exceed 18 digits")]
        public double Amount { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
