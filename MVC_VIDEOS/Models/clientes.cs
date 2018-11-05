using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class clientes
    {
        [Key]
        public long cedula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public virtual ICollection<alquileres> alquileres { get; set; }
    }
}