using System;
namespace Prometheus.Domain.Entities.Estoque
{
    public sealed class SubCategoria :Base
    {
        public SubCategoria(string nome)
        {
            ValidateDomain(nome);
           
        }


        public void update(string nome, Guid idCategoria)
        {
            ValidateDomain(nome);
            
            IdCategoria = idCategoria;
            
        }



        public string Nome {get; private set;}

         public Guid IdCategoria {get; set;}
        
        public Categoria Categoria{get; set;}


         private void ValidateDomain(string nome)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            Nome = nome;
         
        }
    }
    
    

}