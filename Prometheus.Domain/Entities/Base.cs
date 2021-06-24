using System;
using System.Collections.Generic;

namespace Prometheus.Domain.Entities
{
    public abstract class Base
    {
        protected Base()
        {
            this.GlobalId = Guid.NewGuid();;
            this.DataAt = DateTime.Now;
            
        }

        public Guid GlobalId { get; protected set; }
        public DateTime DataAt{get; protected set;}
        public DateTime? DataUt{get; protected set;}

        
    }

}
