using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Xml;
namespace Prometheus.Domain.Interfaces
{
    public interface ICrudGenerico<T> where T :class
    {
         public Task<IEnumerable<T>> SelecionarTodosAnsyc();

        public Task<T> PegaIdAnsyc(Guid GlobalId);
         public  Task<T> IncluirAnsyc(T objeto);
         public Task<T> AlteraAnsyc(T objeto);
         public Task<T> ExcluirAnsyc(T objeto);

         
    }
}