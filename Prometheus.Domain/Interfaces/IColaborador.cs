using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prometheus.Domain.Entities;

namespace Prometheus.Domain.Interfaces
{
    public interface IColaborador
    {

        Task<IEnumerable<Colaborador>> GetColaboradorAsync();
        Task<Colaborador> GetByIdAsync(int? id);

        Task<Colaborador> GetColaboradorAsync(int? id);

        Task<Colaborador> CreateAsync(Colaborador colaborador);
        Task<Colaborador> UpdateAsync(Colaborador colaborador);
        Task<Colaborador> RemoveAsync(Colaborador colaborador);
         
         
    }
}