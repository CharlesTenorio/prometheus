using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;


namespace Prometheus.Domain.Interfaces
{
    public interface IChamados
    {
         Task<IEnumerable<Chamado>> GetChamadoAsync();
        Task<Chamado> GetByIdAsync(int? id);

        Task<Chamado> GetChamadoAsync(int? id);

        Task<Chamado> CreateAsync(Chamado chamado);
        Task<Chamado> UpdateAsync(Chamado chamado);
        Task<Chamado> RemoveAsync(Chamado chamado);
         
    }
}