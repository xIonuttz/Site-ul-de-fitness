using System.ComponentModel.DataAnnotations;

public class Plan
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    public int DurationInDays { get; set; }
}
