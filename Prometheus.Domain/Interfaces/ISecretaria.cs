using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface ISecretaria
    {
        Task<IEnumerable<Secretaria>> GetSecretariaAsync();
        Task<Secretaria> GetByIdAsync(int? id);

        Task<Secretaria> GetSecretariaAsync(int? id);

        Task<Secretaria> CreateAsync(Secretaria secretaria);
        Task<Secretaria> UpdateAsync(Secretaria secretaria);
        Task<Secretaria> RemoveAsync(Secretaria secretaria);
         
    }
}