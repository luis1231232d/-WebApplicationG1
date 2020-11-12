using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationG1.Areas.Identity
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public int DeptoId { get; set; }

        public ICollection<Persona> Personas { get; set; }

        public Depto Depto { get; set; }
    }
}
