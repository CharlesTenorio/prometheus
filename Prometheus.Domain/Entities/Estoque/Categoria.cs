namespace Prometheus.Domain.Entities.Estoque
{
    public sealed  class Categoria :Base
    {
        public Categoria(string nome)
        {
            ValidateDomain(nome);
        }

        public string Nome {get; private set;}


          private void ValidateDomain(string nome)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            Nome = nome;
         
        }
        
    }

    

    
}