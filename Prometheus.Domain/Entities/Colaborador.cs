using System.Security.Cryptography.X509Certificates;
namespace Prometheus.Domain.Entities
{
    public class Colaborador :Base
    {
        public Colaborador(string nome, bool concursado, string fone, string email, string cpf, string idEndereco)
        {
             ValidateDomain(cpf, nome, fone, email);
             IdEndereco = idEndereco;
             Concursado= concursado;
        }

        public string Nome { get; private set ; }

        public bool Concursado{get; private set;}
         public string Fone { get; private set ; }
        public string Email { get; private set ; }

         public string Cpf { get; private set ; }

         public string IdEndereco{get; set;}

         public string IdSecretaria{get; set;}

         

        
        

         private void ValidateDomain(string cpf, string nome, string fone, string email){

            DomainExceptionValidation.When(DomainExceptionValidation.IsCpf(cpf), "Cpf inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(cpf), "CPF nao pode ser vazio");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email nao pode ser nulo");
            DomainExceptionValidation.When(DomainExceptionValidation.IsValidEmail(email), "Formato de email invalido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(fone), "Fone nao pode ser Nulo ou branco");
            this.Cpf= cpf;
            this.Nome = nome;
            this.Email =email;
            this.Fone= fone;
    }
        
    }
}