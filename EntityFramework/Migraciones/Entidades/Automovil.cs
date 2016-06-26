using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migraciones.Entidades
{
    [Table("Automovil")]
    public class Automovil
    {
        public int AutomovilId { get; set; }

        [Required]
        [StringLength(6)]
        public string Placa { get; set; }

        public string Color { get; set; }

        public int MarcaId { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual Persona Persona { get; set; }

        public int PersonaId { get; set; }
    }
}
