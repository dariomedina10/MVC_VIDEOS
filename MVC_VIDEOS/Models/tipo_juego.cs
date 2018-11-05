using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class tipo_juego
    {
        [Key]
        public int id_tipo_juego { get; set; }
        public string descripcion { get; set; }

        public ICollection<alquileres> alquileres { get; set; }
    }
}