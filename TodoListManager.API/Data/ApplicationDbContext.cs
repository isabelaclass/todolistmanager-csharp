using Microsoft.EntityFrameworkCore;

public class ToDoListManagerContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}