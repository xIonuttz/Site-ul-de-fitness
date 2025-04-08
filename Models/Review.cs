using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
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

    public int Rating { get; set; } // 1-5 stele

    public string Comment { get; set; }

    public DateTime ReviewDate { get; set; } = DateTime.Now;
}
