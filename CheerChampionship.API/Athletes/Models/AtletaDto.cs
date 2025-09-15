namespace CheerChampionship.API.AthletesModels.Models
{
    public class AtletaDto
    {
        public string? Nome { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public DocumentoDto? Documento { get; set; } = new DocumentoDto();
    }
}