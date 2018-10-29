using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class GameFilterModel
    {
        public long cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int veces { get; set; }

        public string desc1 { get; set; }
        public string desc2 { get; set; }
        public DateTime fecha_alquiler { get; set; }

    }
}