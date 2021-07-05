using Microsoft.EntityFrameworkCore;

using Prometheus.Domain.Entities;
namespace Prometheus.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Endereco> Enderecos {get; set;}
        public DbSet<Prefeitura> Prefeituras {get; set;}
        public DbSet<Secretaria> Secretarias {get; set;}

        public DbSet<Funcao> Funcaos {get; set;}

        public DbSet<Colaborador> Colaboradores {get; set;}

        public DbSet<Cidadao> Cidadaos {get; set;}

        public DbSet<Demanda> Demandas {get; set;}
        public DbSet<Equipe> Equipes {get; set;}
        public DbSet<Atendimento> Atendimentos {get; set;}

        public DbSet<DetalheAtendimento> DetalhesAtendimentos {get; set;}

        public DbSet<Chamado> Chamados {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }


    }
}