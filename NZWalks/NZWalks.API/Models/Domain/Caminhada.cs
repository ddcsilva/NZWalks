namespace NZWalks.API.Models.Domain
{
    public class Caminhada
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double DistanciaEmKm { get; set; }
        public string? ImagemCaminhadaUrl { get; set; }
        public Guid DificuldadeId { get; set; }
        public Guid RegiaoId { get; set; }

        // Propriedade de navegação
        public Dificuldade Dificuldade { get; set; }
        public Regiao Regiao { get; set; }
    }
}