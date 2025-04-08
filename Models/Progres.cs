using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Progress
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    public float Weight { get; set; }
    public float BodyFatPercentage { get; set; }

    public DateTime RecordedDate { get; set; } = DateTime.Now;
}
