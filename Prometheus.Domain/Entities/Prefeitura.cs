using System;
using System.Collections.Generic;

namespace Prometheus.Domain.Entities
{
    public sealed class Prefeitura : Base
    {
        public Prefeitura(int id, string cnpj, string nome, string email, string fone, string imagem)
        {
            this.Id = id;
            ValidateDomain(cnpj, nome, email, fone, imagem);
            this.DataAt= DateTime.Now;
        }


         public void Update(int id, string cnpj, string nome, string email, string fone, string imagem)
        {
            this.Id = id;
            ValidateDomain(cnpj, nome, email, fone, imagem);
            this.DataAt= DateTime.Now;
        }

       
        public string Image{get; private set;}

        public ICollection<Secretaria> Secretarias{get; set;}

        private void ValidateDomain(string cnpj, string nome, string email, string fone, string imagem){
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            DomainExceptionValidation.When(DomainExceptionValidation.IsCnpj(cnpj), "CNPJ Invalido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email nao pode ser nulo");
            DomainExceptionValidation.When(DomainExceptionValidation.IsValidEmail(email), "Formato de email invalido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(fone), "Fone nao pode ser Nulo ou branco");
            DomainExceptionValidation.When(Image.Length>250, "nome da imagem so pode ter 256");
            
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Fone=fone;
            this.Email =email;
            this.Image =imagem;


        }
    }
}