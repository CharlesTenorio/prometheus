using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface ICidadao
    {
        Task<IEnumerable<Cidadao>> GetCidadaoAsync();
        Task<Cidadao> GetByIdAsync(int? id);

        Task<Cidadao> GetCidadaoAsync(int? id);

        Task<Cidadao> CreateAsync(Cidadao cidadao);
        Task<Cidadao> UpdateAsync(Cidadao cidadao);
        Task<Cidadao> RemoveAsync(Cidadao cidadao);
         
    }
}