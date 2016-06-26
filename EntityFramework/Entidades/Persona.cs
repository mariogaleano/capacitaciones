namespace Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Persona")]
    public partial class Persona
    {
        public Persona()
        {
          
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonaId { get; set; }

        [StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(120)]
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
