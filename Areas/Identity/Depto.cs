using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationG1.Areas.Identity
{
    public class Depto
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }

    }
}
