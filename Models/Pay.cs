using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payment
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; }

    public string Status { get; set; } // Ex: "Pending", "Completed", "Failed"

    public DateTime PaymentDate { get; set; } = DateTime.Now;
}
