using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask.Models
{
    [Table("CentralCusto")]
    public class CentralCusto
    {
        [Key]
        public int Codigo { get; set; }

        public string NomeCusto { get; set; } = null!;

        public decimal ValorAnualMeta { get; set; }
    }
}
