namespace Migraciones
{
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Persona")]
    public partial class Persona
    {
        public Persona()
        {

        }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaId { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(120)]
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public virtual ICollection<Automovil> Automoviles { get; set; }

    }
}
