using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface IEquipe
    {

        Task<IEnumerable<Equipe>> GetFuncaoAsync();
        Task<Equipe> GetByIdAsync(int? id);

        Task<Equipe> GetFuncaoAsync(int? id);

        Task<Equipe> CreateAsync(Equipe equipe);
        Task<Equipe> UpdateAsync(Equipe equipe);
        Task<Equipe> RemoveAsync(Equipe equipe);
         
    }
}