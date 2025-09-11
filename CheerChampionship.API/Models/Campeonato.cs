namespace CheerChampionship.API.Models
{
    public class Campeonato
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Local { get; set; } = string.Empty;
    }
}