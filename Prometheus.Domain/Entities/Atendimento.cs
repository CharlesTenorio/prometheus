using System.Collections;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace Prometheus.Domain.Entities
{
    public class Atendimento :Base
    {
        
        public DateTime DataFinal{get; private set;}
        public string StatusAtendimento{get; private set;}

       public Guid IdChamado{get; set;}

       public Chamado Chamado{get; set;}
        public Atendimento(DateTime dataFinal, string statusAtendimento)
        {
            DataFinal = dataFinal;
            StatusAtendimento= statusAtendimento;
           
        }


        public void Update(DateTime dataFinal, string statusAtendimento, Guid idChamado)
        {
            DataFinal = dataFinal;
            StatusAtendimento= statusAtendimento;
            IdChamado = idChamado;
        }




    }
}