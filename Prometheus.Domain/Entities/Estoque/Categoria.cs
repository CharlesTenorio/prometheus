using System;
using System.Collections;
using System.Collections.Generic;
namespace Prometheus.Domain.Entities.Estoque
{
    public sealed  class Categoria :Base
    {
        public Categoria(string nome)
        {
            ValidateDomain(nome);
        }

        public void Update(string nome)
        {
            ValidateDomain(nome);
        }

        public string Nome {get; private set;}

        public ICollection<Produto> Produtos{get; set;}

        public ICollection<SubCategoria> SubCategorias{get; set;}

          private void ValidateDomain(string nome)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            Nome = nome;
         
        }
        
    }

    

    
}