namespace ProjZtpai.Dto;
using System.ComponentModel.DataAnnotations;

public class PinCreateDto
{
    [Required]
    [Range(-91.0f, 91.0f, ErrorMessage = "Invalid Latitude")]
    public float? Latitude { get; set; }

    [Required]
    [Range(-181.0f, 181.0f, ErrorMessage = "Invalid Longitude")]
    public float? Longitude { get; set; }

    [Required]
    public string Title { get; set; } = "";
}