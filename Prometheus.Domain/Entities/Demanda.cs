using System.Collections.Generic;
namespace Prometheus.Domain.Entities
{
    public sealed  class Demanda :Base
    {
        public Demanda(string nome, string codigo, int idSecretaria)
        {
             DomainExceptionValidation.When(idSecretaria < 0, "Invalid Id value");
             IdSecretaria = idSecretaria;
             ValidateDomain(nome, codigo);
        }

        public string Nome{get; private set;}
        public string Codigo{get; private set;}

        public int IdSecretaria{get; private set;}
        public ICollection <Chamado> Chamados{get; set;}
       
    
         private void ValidateDomain(string nome, string codigo){
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Cidade  nao pode ser null ou em branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(codigo), "Email nao pode ser nulo");
            this.Nome=nome;
            this.Codigo = codigo;

        }

        
    }
}