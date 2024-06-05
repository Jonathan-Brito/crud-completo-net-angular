using CadastroUsuarios.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuarios.Contexts;

public class SqlServerContext : DbContext
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .Property(u => u.Id)
            .ValueGeneratedOnAdd();
    }

    DbSet<Usuario> Usuarios {  get; set; }
}
