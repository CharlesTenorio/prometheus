using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;

namespace Prometheus.Domain.Entities
{
    public sealed class Chamado:Base
    {
        
        public string Referencia{get; set;}
        public string Descricao{get; set;} 

        public string? Resposta{get; set;}

        public string? Foto{get; set;}

        public string StatusChado{get; set;}

        public Guid IdDemanda{get; set;}

        public Demanda Demanda{get; set;}

        public Guid IdCidadao{get; set;}

        public Cidadao Cidadao{get; set;}


        public ICollection<Atendimento> Atendimentos{get; set;}
        
        
        
        public Chamado(string referencia, string descricao, string resposta, string foto, string statusChado)
        {
            ValidateDomain(referencia, descricao);
            Resposta = resposta;
            Foto = foto;
            StatusChado = statusChado;
           
        }



        public void Update(string referencia, string descricao, string resposta, string foto, string statusChado, Guid idDemanda,  Guid idCidadao)
        {
            ValidateDomain(referencia, descricao);
            Resposta = resposta;
            Foto = foto;
            StatusChado = statusChado;
            IdDemanda = idDemanda;
            IdCidadao = idCidadao;
        }

        


        private void ValidateDomain(string referencia, string descricao)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(referencia), "Campo obrigatorio");
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao), "CPF nao pode ser vazio");
            DomainExceptionValidation.When(referencia.Length<10, "Nao pode ter menos que 10 caracteres");
            DomainExceptionValidation.When(descricao.Length<20, "Nao pode ter menos que 20 caracteres");
           
        }
    }

 
}