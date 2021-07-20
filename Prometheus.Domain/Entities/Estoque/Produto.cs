using System.Collections.Generic;
using System;
namespace Prometheus.Domain.Entities.Estoque
{
    public sealed class Produto :Base
    {
        public Produto(string nome, string codeBarra, string descricao, string image, int fator, int qtdAtual, int qtdMinima, int qtdMaxima, bool loteValidade, string lote, DateTime? validade, int qtdDiasPraVencer, bool ativo, Guid idCategoria, Categoria categoria, Guid idSubCategoria, SubCategoria subCategoria)
        {
            Nome = nome;
            CodeBarra = codeBarra;
            Descricao = descricao;
            Image = image;
            Fator = fator;
            QtdAtual = qtdAtual;
            QtdMinima = qtdMinima;
            QtdMaxima = qtdMaxima;
            LoteValidade = loteValidade;
            Lote = lote;
            Validade = validade;
            QtdDiasPraVencer = qtdDiasPraVencer;
            Ativo = ativo;
            IdCategoria = idCategoria;
            Categoria = categoria;
            IdSubCategoria = idSubCategoria;
            SubCategoria = subCategoria;
        }

        public string Nome{get; private set;}
      public string? CodeBarra{get; private set;}
      public string Descricao{get; private set;}
      public string? Image{get; private set;}
      public int Fator{get; private set;}
      public  int QtdAtual{get; private set;}
      public int QtdMinima{get; private set;}
      public int QtdMaxima{get; private set;}
      public bool LoteValidade{get; private set;}
      public string? Lote{get; private set;}
      public DateTime? Validade{get; private set;}
      public int QtdDiasPraVencer{get; private set;}
      public bool Ativo{get; private set;}
      public Guid IdCategoria{get; set;}
      public Categoria Categoria{get; set;}
      public Guid IdSubCategoria{get; set;}
      public SubCategoria SubCategoria{get; set;}


         private void ValidateDomain(string nome, string? codeBarra, string descricao, int qtdAtual, int qtdMinima, int qtdMaxima,  string? lote, DateTime? validade, int fator)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome nao pode ser null ou em branco");
            DomainExceptionValidation.When(string.IsNullOrEmpty(codeBarra), "Codigo de Barra obrigatorio");
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao), "Descricao obrigatória");
            DomainExceptionValidation.When(DomainExceptionValidation.QtdMaiorIgualZero(qtdAtual), "Quantida de Nao pode ser negativa");
            DomainExceptionValidation.When(DomainExceptionValidation.QtdMaiorIgualZero(qtdMinima), "Quantida de Nao pode ser negativa");
            DomainExceptionValidation.When(DomainExceptionValidation.QtdMaiorIgualZero(qtdMaxima), "Quantida de Nao pode ser negativa");
            DomainExceptionValidation.When(DomainExceptionValidation.QtdMaiorIgualZero(fator), "Quantida de Nao pode ser negativa");
            
            
            if (LoteValidade){
                 DomainExceptionValidation.When(string.IsNullOrEmpty(lote), "Numero do Lote e obrigatório");
                 DomainExceptionValidation.When(DomainExceptionValidation.IsDataMaioOuGualDataAtautal((DateTime)validade),"Data invalida");
                 Lote=lote;
                 Validade=validade;
                
            }

            Nome = nome;
            CodeBarra = codeBarra;

         
        }

        
    }
}