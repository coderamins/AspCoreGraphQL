using Microsoft.EntityFrameworkCore;

public class ApplicationContext:DbContext
{
    public ApplicationContext(DbContextOptions options):base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Owner> Owners { get; set; }
}