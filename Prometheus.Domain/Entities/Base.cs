using System;
using System.Collections.Generic;

namespace Prometheus.Domain.Entities
{
    public abstract class Base
    {

        public int Id { get; protected set ; }
        public string Cnpj{get; protected set;}
         public string Nome { get; protected set ; }
        public string Fone { get; protected set ; }
        public string Email { get; protected set ; }
        
        public DateTime DataAt{get; protected set;}
        public DateTime? DataUt{get; protected set;}

        
    }

}
