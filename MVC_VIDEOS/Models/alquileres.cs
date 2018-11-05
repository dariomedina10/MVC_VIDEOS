using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class alquileres
    {
        [Key]
        public int id_alquiler { get; set; }
            public Nullable<long> ci_cliente { get; set; }
            public Nullable<int> id_juego { get; set; }
            public Nullable<System.DateTime> fecha_alquier { get; set; }
            public Nullable<int> id_tipo_juego { get; set; }

            public virtual clientes clientes { get; set; }
            public virtual juegos juegos { get; set; }
            public virtual tipo_juego tipo_juego { get; set; }
        
    }
}