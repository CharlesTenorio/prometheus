using System.Collections.Generic;

namespace Prometheus.Domain.Entities
{
    public class Equipe :Base
    {
         public string Nome {get; set;}

      
        public Equipe(string nome)
        {
            ValidateDomain(nome);
        }


         public void Update(string nome)
        {
            ValidateDomain(nome);
        }


        ICollection<Colaborador> Colaboradores{get; set;}
        ICollection<DetalheAtendimento> DetalheAtendimentos{get; set;}

      


        private void ValidateDomain(string nome)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            Nome = nome;
         
    }
        
    }
}