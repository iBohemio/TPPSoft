//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPP.DL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoContenedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoContenedor()
        {
            this.Contenedor = new HashSet<Contenedor>();
            this.Pesaje = new HashSet<Pesaje>();
        }
    
        public int TipoContenedorId { get; set; }
        public string Descripcion { get; set; }
        public short Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contenedor> Contenedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pesaje> Pesaje { get; set; }
    }
}
