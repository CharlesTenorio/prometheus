using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface IAtendimento
    {
         Task<IEnumerable<Atendimento>> GetAtendimentoAsync();
        Task<Atendimento> GetByIdAsync(int? id);

        Task<Atendimento> GetAtendimentoAsync(int? id);

        Task<Atendimento> CreateAsync(Atendimento atendimento);
        Task<Atendimento> UpdateAsync(Atendimento atendimento);
        Task<Atendimento> RemoveAsync(Atendimento atendimento);
         
    }
}