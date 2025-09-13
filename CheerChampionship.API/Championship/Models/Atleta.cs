namespace CheerChampionship.API.Models
{
    public class Atleta
    {
        public string? Nome { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public Documento? Documento { get; set; } = new Documento();
    }
}