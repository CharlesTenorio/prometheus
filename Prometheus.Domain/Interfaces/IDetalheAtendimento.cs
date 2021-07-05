using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;


namespace Prometheus.Domain.Interfaces
{
    public interface IDetalheAtendimento
    {
         Task<IEnumerable<DetalheAtendimento>> GetDetalheAtendimentosync();
        Task<DetalheAtendimento> GetByIdAsync(int? id);

        Task<DetalheAtendimento> GetDetalheAtendimentoAsync(int? id);

        Task<DetalheAtendimento> CreateAsync(DetalheAtendimento detalheAtendimento);
        Task<DetalheAtendimento> UpdateAsync(DetalheAtendimento detalheAtendimento);
        Task<DetalheAtendimento> RemoveAsync(DetalheAtendimento detalheAtendimento);
         
    }
}