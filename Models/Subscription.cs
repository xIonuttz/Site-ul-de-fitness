using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Subscription
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    [Required]
    [ForeignKey("Plan")]
    public int PlanId { get; set; }
    public Plan Plan { get; set; }

    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; }
}
