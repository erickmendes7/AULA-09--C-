
using Microsoft.EntityFrameworkCore;

public class UniversidadeContext : DbContext
{
    public UniversidadeContext(
        DbContextOptions<UniversidadeContext> options
    ) : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
}