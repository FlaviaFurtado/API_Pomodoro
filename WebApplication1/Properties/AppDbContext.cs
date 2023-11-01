using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<TarefaModel> Tarefas { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}