using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask.Models
{
    [Table("Incidente")]
    public partial class Incidente
    {
        [Key]
        public int Codigo { get; set; }

        public string DescricaoProblema { get; set; } = null!;

        public DateTime DataIncidente { get; set; }

        public string? Solucao { get; set; }

        public string Resolvido { get; set; } = null!;
    }
}
