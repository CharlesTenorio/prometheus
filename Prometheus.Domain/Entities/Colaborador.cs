using System;
using System.Security.Cryptography.X509Certificates;
namespace Prometheus.Domain.Entities
{
    public class Colaborador :Base
    {
        

        public string Nome { get; private set ; }

        public bool Concursado{get; private set;}
         public string Fone { get; private set ; }
        public string Email { get; private set ; }

         public string Cpf { get; private set ; }

         public Guid IdEndereco{get; set;}

         public Endereco Endereco{get; set;}

         public Guid IdSecretaria{get; set;}

         public Secretaria Secretaria{get; set;}


         public Funcao Funcao{get; set;}
         public Guid IdFuncao{get; set;}

         public Equipe Equipe{get; set;}
         public Guid IdEquipe{get; set;}
        
        public Colaborador(string nome, bool concursado, string fone, string email, string cpf)
        {
             ValidateDomain(cpf, nome, fone, email);
            
             Concursado= concursado;
        }



        public void Update(string nome, bool concursado, string fone, string email, string cpf, Guid idFuncao, Guid idSecretaria)
        {
             ValidateDomain(cpf, nome, fone, email);
             IdFuncao=idFuncao;
             IdSecretaria =idSecretaria;
             Concursado= concursado;
        }



        

         

        
        

         private void ValidateDomain(string cpf, string nome, string fone, string email){

            DomainExceptionValidation.When(DomainExceptionValidation.IsCpf(cpf), "Cpf inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(cpf), "CPF nao pode ser vazio");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email nao pode ser nulo");
            DomainExceptionValidation.When(DomainExceptionValidation.IsValidEmail(email), "Formato de email invalido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(fone), "Fone nao pode ser Nulo ou branco");
            Cpf= cpf;
            Nome = nome;
            Email =email;
            Fone= fone;
    }
        
    }
}