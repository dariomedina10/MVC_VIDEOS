using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class juegos
    {
        [Key]
        public int id_juego { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> tipo { get; set; }

        public virtual ICollection<alquileres> alquileres { get; set; }
    }
}