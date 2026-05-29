namespace ProjZtpai.Models;

public class Pin
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public float Latitude { get; set; }

    public float Longitude { get; set; }

    public string Title { get; set; } = "";
}