namespace CheerChampionship.Infrastructure.Data.Models
{
    public class Campeonato
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string Location { get; set; } = string.Empty;
    }
}