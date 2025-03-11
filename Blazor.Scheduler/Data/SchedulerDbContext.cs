using Microsoft.EntityFrameworkCore;

public class SchedulerDbContext : DbContext
{
    public SchedulerDbContext(DbContextOptions<SchedulerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Blazor.Scheduler.Entities.Catalog> Catalog { get; set; } = default!;
}
