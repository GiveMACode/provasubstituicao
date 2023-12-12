using ProvaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaAPI.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext>options) : base(options){} 

    public DbSet<Aluno> Alunos{ get ; set; }
    public DbSet<IMC> IMCs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IMC>().HasData(
            new IMC {IMCId = 1, Classificacao = "Magreza", Altura = 115, Peso = 0, ValorImc = 0 }
        );
    
        modelBuilder.Entity<Aluno>().HasData( 
            new Aluno { AlunoId = 1, DataDeNascimento = "10 de Setembro de 2000", IMCId = 1, Nome = "xuxu beleza"  }
        );

        }
        
}
