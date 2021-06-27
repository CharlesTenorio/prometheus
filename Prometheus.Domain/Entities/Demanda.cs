using System.Collections.Generic;
namespace Prometheus.Domain.Entities
{
    public sealed  class Demanda :Base
    {
        public Demanda(string nome, string codigo, int idSecretaria)
        {
            
             IdSecretaria = IdSecretaria;
             ValidateDomain(nome, codigo);
        }

        public string Nome{get; private set;}
        public string Codigo{get; private set;}

        public string IdSecretaria{get; private set;}

        public Secretaria Secretaria{get; set;}
        public ICollection <Chamado> Chamados{get; set;}
       
    
         private void ValidateDomain(string nome, string codigo){
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Cidade  nao pode ser null ou em branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(codigo), "Email nao pode ser nulo");
            this.Nome=nome;
            this.Codigo = codigo;

        }

        
    }
}