namespace NZWalks.API.Models.Domain
{
    public class Regiao
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public string? ImagemUrl { get; set; }
    }
}