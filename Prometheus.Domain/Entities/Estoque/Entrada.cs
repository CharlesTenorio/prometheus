using System.ComponentModel.DataAnnotations;
using System;
namespace Prometheus.Domain.Entities.Estoque
{
    public sealed class Entrada : Base
    {
        

        public DateTime DataEntrada{get; private set;}
       public string Documento{get; private set;}
       public string Descricao{get; private set;}
       public string NumNotaFiscal{get; private set;}
       public decimal ValorNota{get; private set;}
       public Guid IdFornecedor{get; private set;}
       public Fornecedor Fornecedor{get; set;}
       public Guid IdSecretaria{get; set;}
       public Secretaria Secretaria{get; set;}

       public Entrada(string documento, string descricao, string numNotaFiscal, decimal valorNota)
        {
            DataEntrada = DateTime.Now;
            ValidateDomain(documento, descricao, numNotaFiscal, valorNota);
            
        }


        public void Update(string documento, string descricao, string numNotaFiscal, decimal valorNota, Guid idFornecedor, Guid idSecretaria)
        {
            
            Documento = documento;
            Descricao = descricao;
            NumNotaFiscal = numNotaFiscal;
            ValorNota = valorNota;
            IdFornecedor = idFornecedor;
            IdSecretaria = idSecretaria;
            
        }

       
       
       private void ValidateDomain(string documento, string descricao, string numNotaFiscal, decimal valorNota)
       {
             DomainExceptionValidation.When(string.IsNullOrEmpty(documento), "campo obrigatório"); 
             DomainExceptionValidation.When(string.IsNullOrEmpty(descricao), "campo obrigatório");
             DomainExceptionValidation.When(string.IsNullOrEmpty(numNotaFiscal), "campo obrigatório");
             DomainExceptionValidation.When(valorNota<0, "valor inválido");

             Documento=documento;
             Descricao=descricao;
             NumNotaFiscal=numNotaFiscal;
             ValorNota=valorNota; 
       }

    
}