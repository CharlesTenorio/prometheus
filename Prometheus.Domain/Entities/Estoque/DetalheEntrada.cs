using System.Collections.Generic;
using System;
namespace Prometheus.Domain.Entities.Estoque
{
    public class DetalheEntrada :  Base
    {
        public Guid IdEntrada{get; set;}
        public Entrada Entrada{get; set;}

        public Guid IdLoteValidade{get; set;}
        public LoteValidade LoteValidade{get; set;}

        public Guid IdProduto{get; set;}
        public ICollection<Produto> Produtos {get; set;}
        public int Quantidade{get; private set;}
        public decimal ValorCompra{get; private set;}
        public decimal SubTotal{get; private set;}

        public DetalheEntrada(int quantidade, decimal valorCompra, decimal subTotal)
        {
           ValidateDomain(quantidade, valorCompra, subTotal);
           
        }

        public void Update(Guid idEntrada, Guid idLoteValidade, Guid idProduto, int quantidade, decimal valorCompra, decimal subTotal)
        {
             ValidateDomain(quantidade, valorCompra, subTotal);
            IdEntrada = idEntrada;
            IdLoteValidade = idLoteValidade;
            IdProduto=idProduto;
           
        }

         private void ValidateDomain(int quantidade, decimal valorCompra, decimal subTotal){
            DomainExceptionValidation.When(quantidade <0, "Quantidade invalida");
            DomainExceptionValidation.When(valorCompra <0, "Valor de compra invalido");
            DomainExceptionValidation.When(subTotal < 0, "Sbutotal inválido");
            Quantidade=quantidade;
            ValorCompra=valorCompra;
            SubTotal=subTotal;

        }


    }
}