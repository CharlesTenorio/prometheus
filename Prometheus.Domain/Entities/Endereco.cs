using System.Collections;
using System.Collections.Generic;
namespace Prometheus.Domain.Entities
{
    public sealed  class Endereco :Base
    {
        public Endereco(string cidade, string bairro, string rua, string cep, string zona)
        {
            ValidateDomain(cidade, bairro, rua, zona);
            Cep = cep;
        
        }

        public string Cidade { get; private set ; }
        public string Bairro { get; private set ; }
         public string Rua { get; private set ; }
         public string Cep { get; private set ; }
         public string Zona { get; private set ; }
         public ICollection <Cidadao>Cidadoes{get; set;}

         public ICollection<Chamado>Chamados{get; set;}

         public ICollection<Colaborador>Colaboradores{get; set;}

         public ICollection<Prefeitura>Prefeituras{get; set;}
          


         private void ValidateDomain(string cidade, string bairro, string rua, string zona){
            DomainExceptionValidation.When(string.IsNullOrEmpty(cidade), "Cidade  nao pode ser null ou em branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(bairro), "Bairro nao pode ser nulo");
            DomainExceptionValidation.When(string.IsNullOrEmpty(zona), "Zona nao pode ser vazia");
            Cidade = cidade;
            Bairro = bairro;
            Rua=rua;
            Zona = zona;
           


        }
        
    }
}