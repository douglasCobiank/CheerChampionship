using System;
using System.ComponentModel.DataAnnotations;

namespace CheerChampionship.Infrastructure.Data.Models
{
    public class Equipe
    {
        [Key]
        public int Id { get; set; }
        
        public string? Nome { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? Responsavel { get; set; }

        public string? EmailResponsavel { get; set; }

        public string? TelefoneResponsavel { get; set; }
    }
}