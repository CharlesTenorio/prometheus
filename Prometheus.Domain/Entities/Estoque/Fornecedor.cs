
using System;

namespace Prometheus.Domain.Entities.Estoque
{
    public sealed class  Fornecedor :Base
    {
       
       public string Nome{get;  private set;}

        public string Fone{get; private set;}

        public string Cnpj{get; private set;}

        public Guid IdEndereco{get; set;}

        public Endereco Endereco{get; private set;}

        public string Email{get; private set;}

        public string Responsavel{get; private set;}

        public string FoneResponsavel {get; private set;}
        public bool Ativo {get; private set;}

        public string Obs{get; private set;}

       
        public Fornecedor(string nome, string fone, string cnpj, string email, string responsavel, string foneResponsavel, bool ativo, string obs)
        {
            ValidateDomain(nome, fone, cnpj, email, responsavel, foneResponsavel);
            Ativo = ativo;
            Obs = obs;
        }




        public void Update(string nome, string fone, string cnpj, Guid idEndereco, Endereco endereco, string email, string responsavel, string foneResponsavel, bool ativo, string obs)
        {
            ValidateDomain(nome, fone, cnpj, email, responsavel, foneResponsavel);
            IdEndereco = idEndereco;
            Ativo = ativo;
            Obs = obs;
        }

        


        private void ValidateDomain(string nome, string fone, string cnpj, string email, string responsavel, string foneResponsavel){
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            DomainExceptionValidation.When(DomainExceptionValidation.IsCnpj(cnpj), "CNPJ Invalido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email nao pode ser nulo");
            DomainExceptionValidation.When(DomainExceptionValidation.IsValidEmail(email), "Formato de email invalido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(fone), "Fone nao pode ser Nulo ou branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(responsavel), "Responsável nao pode ser Nulo ou branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(foneResponsavel), "Fone do responsavel nao pode ser Nulo ou branco");
           
            Nome = nome;
            Cnpj = cnpj;
            Fone=fone;
            Email =email;
            Responsavel=responsavel;
            FoneResponsavel=foneResponsavel;
            


        }

        
    }
}