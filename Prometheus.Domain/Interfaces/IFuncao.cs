using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface IFuncao
    {
        Task<IEnumerable<Funcao>> GetFuncaoAsync();
        Task<Funcao> GetByIdAsync(int? id);

        Task<Funcao> GetFuncaoAsync(int? id);

        Task<Funcao> CreateAsync(Funcao funcao);
        Task<Funcao> UpdateAsync(Funcao funcao);
        Task<Funcao> RemoveAsync(Funcao funcao);
         
    }
}