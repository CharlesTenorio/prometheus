using System;

namespace Prometheus.Domain.Entities
{
    public class DetalheAtendimento : Base
    {
        public Guid Idequipe{get;  set;}

         public Guid IdAtendimento{get; set;}

       public string DescricaoTec{get;  set;}

       public string? DescricaoSolucao{get; set;}


       public string StatusDetalhe{get; set;}
      
        public DetalheAtendimento(Guid idequipe, Guid idatendimento, string descricaoTec, string descricaoSolucao, string statusDetalhe)
        {
            ValidateDomain(idequipe, idatendimento, descricaoTec, statusDetalhe);
            descricaoSolucao = descricaoSolucao;
        }


        public void Update(Guid idequipe, Guid idatendimento, string descricaoTec, string descricaoSolucao, string statusDetalhe)
        {
            ValidateDomain(idequipe, idatendimento, descricaoTec, statusDetalhe);
            descricaoSolucao = descricaoSolucao;
        }

         


         private void ValidateDomain(Guid idequipe, Guid idatendimento, string descricaoTec, string statusDetalhe)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricaoTec), "Dados obrigatórios");
            DomainExceptionValidation.When(Guid.Empty==idatendimento, "Dados obrigatórios");
            DomainExceptionValidation.When(Guid.Empty==idequipe, "Dados obrigatórios");
            DomainExceptionValidation.When(string.IsNullOrEmpty(statusDetalhe), "Dados obrigatórios");
            
            Idequipe=idequipe;
            IdAtendimento= idatendimento;
            DescricaoTec=descricaoTec;
            StatusDetalhe=statusDetalhe;

           
         
        }

      
        
    }
}