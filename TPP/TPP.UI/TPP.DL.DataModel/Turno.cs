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
    
    public partial class Turno
    {
        public Turno()
        {
            this.Reporte = new HashSet<Reporte>();
        }
    
        public int TurnoId { get; set; }
        public string Nombre { get; set; }
        public int HoraInicio { get; set; }
        public int MinutoInicio { get; set; }
        public int HoraFin { get; set; }
        public int MinutoFin { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<Reporte> Reporte { get; set; }
    }
}
