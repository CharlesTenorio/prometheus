using System;


namespace Prometheus.Domain.Entities
{
    public sealed class Prefeitura
    {
        public Prefeitura(string cnpj, string nome, string email, string fone)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.email = email;
            this.fone = fone;
        }

        public string cnpj{get; private set;}
        public string nome{get; private set;}
        public string email{get; private set;}

        public string fone{get; private set;}

        private void ValidateDomain(string cnpj, string nome, string email, string fone){
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            this.nome = nome;
            
            if(DomainExceptionValidation.IsCnpj(cnpj)){
               this.cnpj=cnpj;

            }
            else{
                throw
            }


        }
    }
}