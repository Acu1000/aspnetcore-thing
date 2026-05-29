using System.ComponentModel.DataAnnotations;

namespace ProjZtpai.Models;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; } = "";

    public string PasswordHash { get; set; } = "";
}