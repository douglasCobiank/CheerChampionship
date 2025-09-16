namespace CheerChampionship.Infrastructure.Data.Models
{
    public class AtletaData
    {
        public int Id { get; set; }
        
        public string? Nome { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public DocumentoData? Documento { get; set; } = new DocumentoData();
    }

    public class DocumentoData
    {
        public string? CPF { get; set; }
        
        public string? RG { get; set; }
    }
}