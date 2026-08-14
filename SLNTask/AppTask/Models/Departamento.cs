using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask.Models
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        public int Codigo { get; set; }

        public string Descricao { get; set; } = null!;

        public Boolean Ativo { get; set; }
    }
}
