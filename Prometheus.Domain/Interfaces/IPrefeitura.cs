using System;
using System.Collections.Generic;
using Prometheus.Domain.Entities;
using System.Threading.Tasks;


namespace Prometheus.Domain.Interfaces
{
    public interface IPrefeitura
    {
         Task<IEnumerable<Prefeitura>> GetPrefituras();
        Task<Prefeitura> GetById(Guid? id);

        Task<Prefeitura> Create(Prefeitura prefeitura);
        Task<Prefeitura> Update(Prefeitura prefeitura);
        Task<Prefeitura> Remove(Prefeitura prefeitura);
    }
}