using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationG1.Areas.Identity
{
    public class Persona
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Apellido { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(5)]
        public int CiudadID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fechanac { get; set; }

        public Ciudad Ciudad { get; set; }

    }
}
