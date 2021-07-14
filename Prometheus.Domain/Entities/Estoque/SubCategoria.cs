using System;
namespace Prometheus.Domain.Entities.Estoque
{
    public sealed class SubCategoria :Base
    {
         public string Nome {get; private set;}

         public Guid IdCategoria {get; set;}
        
    }
}