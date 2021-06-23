using System;
using System.Collections.Generic;

namespace Prometheus.Domain.Entities
{
    public abstract class Base
    {

        public int Id { get; protected set ; }
        public DateTime DataAt{get; protected set;}
        public DateTime? DataUt{get; protected set;}

        
    }

}
