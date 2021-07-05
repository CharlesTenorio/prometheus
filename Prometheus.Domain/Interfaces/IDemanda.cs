using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;


namespace Prometheus.Domain.Interfaces
{
    public interface IDemanda
    {
        Task<IEnumerable<Demanda>> GetDemandaAsync();
        Task<Demanda> GetByIdAsync(int? id);

        Task<Demanda> GetFuncaoAsync(int? id);

        Task<Demanda> CreateAsync(Demanda demanda);
        Task<Demanda> UpdateAsync(Demanda demanda);
        Task<Demanda> RemoveAsync(Demanda demanda);
         
    }
}