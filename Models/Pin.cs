using System.ComponentModel.DataAnnotations;

namespace ProjZtpai.Models;

public class Pin
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    [Required]
    public float Latitude { get; set; }

    [Required]
    public float Longitude { get; set; }

    [Required]
    public string Title { get; set; } = "";
}