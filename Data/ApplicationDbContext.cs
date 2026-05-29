using Microsoft.EntityFrameworkCore;
using ProjZtpai.Models;

namespace ProjZtpai.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Pin> Pins => Set<Pin>();
}
