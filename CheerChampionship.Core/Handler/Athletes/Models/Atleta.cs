namespace CheerChampionship.Core.Handler.Athletes.Models
{
    public class Atleta
    {
        public required string Nome { get; set; }

        public required string Cidade { get; set; }

        public required string Estado { get; set; }

        public Documento? Documento { get; set; } = new Documento();
    }
}