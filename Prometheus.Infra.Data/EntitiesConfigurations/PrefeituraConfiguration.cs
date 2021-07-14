using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prometheus.Domain.Entities;


namespace Prometheus.Infra.Data.EntitiesConfigurations
{
    public class PrefeituraConfiguration : IEntityTypeConfiguration<Prefeitura>
    {
        public void Configure(EntityTypeBuilder<Prefeitura> builder)
        {
            builder.HasKey(t=>t.GlobalId);
            builder.Property(p=>p.Cnpj).HasMaxLength(20).IsRequired();
            builder.Property(p=>p.Fone).HasMaxLength(100).IsRequired();
            builder.Property(p=>p.Email).HasMaxLength(150).IsRequired();
            builder.HasOne(e => e.Endereco).WithOne(e => e.Prefeituras)
                .HasForeignKey<Prefeitura>(e => e.IdEndereco);
        }
    }
}

