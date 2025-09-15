using System.ComponentModel.DataAnnotations;

namespace CheerChampionship.Core.Handler.Championships.Models
{
    public class Campeonato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string Location { get; set; } = string.Empty;
    }
}