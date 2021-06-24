using System.Collections.Generic;
using System;


namespace Prometheus.Domain.Entities
{
    public sealed class Secretaria : Base
    {
        
        public int CodigoPrefeitura { get; set ; }
       
        public Prefeitura prefeitura {get; set;}


        public string Cnpj{get; private set;}
         public string Nome { get; private set ; }
        public string Fone { get; private set ; }
        public string Email { get; private set ; }

        public ICollection<Demanda> Demandas{get; set;}
        public ICollection<Colaborador>Colaboradores{get; set;}
        

        public Secretaria(string cnpj, int id, int codigoPrefeitura, string nome, string fone, string email, Prefeitura prefeitura)
        {
            this.Id = id;
            this.CodigoPrefeitura = codigoPrefeitura;
            ValidateDomain(cnpj, nome, fone, email);
            this.prefeitura = prefeitura;
            this.DataAt=DateTime.Now;
        }


        public void Update(string cnpj, int id, int codigoPrefeitura, string nome, string fone, string email, Prefeitura prefeitura)
        {
            this.Id = id;
            this.CodigoPrefeitura = codigoPrefeitura;
            ValidateDomain(cnpj, nome, fone, email);
            this.prefeitura = prefeitura;
        }


         private void ValidateDomain(string cnpj, string nome, string fone, string email){
             DomainExceptionValidation.When(DomainExceptionValidation.IsCnpj(cnpj), "CNPJ Invalido");
             this.Cnpj = cnpj;
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            this.Nome = nome;
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email nao pode ser nulo");
            DomainExceptionValidation.When(DomainExceptionValidation.IsValidEmail(email), "Formato de email invalido");
            this.Email =email;
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(fone), "Fone nao pode ser Nulo ou branco");
            this.Fone= fone;
        }

    }

}
 