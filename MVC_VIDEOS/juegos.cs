//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_VIDEOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class juegos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public juegos()
        {
            this.alquileres = new HashSet<alquileres>();
        }
    
        public int id_juego { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alquileres> alquileres { get; set; }
    }
}
