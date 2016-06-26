using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migraciones.Entidades
{
    [Table("Marca")]
    public class Marca
    {
        public int MarcaId { get; set; }

        [Required]        
        public string Nombre { get; set; }
    }
}