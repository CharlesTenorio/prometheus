namespace Prometheus.Domain.Entities
{
    public sealed class Chamado:Base
    {
        public string Referencia{get; set;}
        public string Descricao{get; set;} 

        public string? Resposta{get; set;}

        public string? Foto{get; set;}

        public string StatusChado{get; set;}


    }
}