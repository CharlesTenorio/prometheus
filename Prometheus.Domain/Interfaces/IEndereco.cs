
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface IEndereco
    {
        Task<IEnumerable<Endereco>> GetPrefiturasAsync();
        Task<Endereco> GetByIdAsync(Guid? id);

        Task<Endereco> CreateAsync(Endereco endereco);
        Task<Endereco> UpdateAsync(Endereco endereco);
        Task<Endereco> RemoveAsync(Endereco endereco);
         
    }
}