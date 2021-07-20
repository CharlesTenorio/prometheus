using System;
using System.Collections.Generic;

namespace Prometheus.Domain.Entities.Estoque
{
    public sealed class LoteValidade:Base
    {
        public LoteValidade(string numeroLote,  DateTime validade)
        {
            ValidateDomain(numeroLote, validade);
        }


        public void update(string numeroLote, Guid idFornecedor, DateTime validade)
        {
            ValidateDomain(numeroLote, validade);
            IdFornecedor=idFornecedor;

        }

        private void ValidateDomain(string numeroLote,  DateTime validade){
            DomainExceptionValidation.When(string.IsNullOrEmpty(numeroLote), "Numero do Lote nao pode ser null ou em branco");
            DomainExceptionValidation.When(DomainExceptionValidation.IsDataMaioOuGualDataAtautal(validade), "Data da vailidade incorreta");
        }

       public string NumeroLote{get; private set;}
       public ICollection<Produto> Produtos{get; set;} 
       public Guid IdFornecedor{get; set;} 
       public Fornecedor Fornecedor {get; set;}
       public DateTime Validade{get; private set;}
    }
}