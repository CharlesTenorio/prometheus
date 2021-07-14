using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prometheus.Domain.Entities;

namespace Prometheus.Infra.Data.EntitiesConfigurations
{
    public class EnderecoConfigurations : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(t=>t.GlobalId);
            builder.Property(p=>p.Cidade).HasMaxLength(100).IsRequired();
            builder.Property(p=>p.Bairro).HasMaxLength(100).IsRequired();
            builder.Property(p=>p.Rua).HasMaxLength(100).IsRequired();
            builder.Property(p=>p.Zona).HasMaxLength(100).IsRequired();
            builder.Property(p=>p.Cep).HasMaxLength(100);   
        }
    }
}