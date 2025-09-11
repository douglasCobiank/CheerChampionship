namespace CheerChampionship.API.Models
{
    public class Categoria
    {
        public int Nivel { get; set; } = 1;
        public string? Tipo { get; set; }
        public int QtdeAtletas { get; set; } = 0;
        public string? Divisao { get; set; }
    }
}