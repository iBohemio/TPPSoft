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
    
    public partial class Pesaje
    {
        public Pesaje()
        {
            this.AuditoriaPesaje = new HashSet<AuditoriaPesaje>();
            this.GuiaRemision = new HashSet<GuiaRemision>();
            this.MovimientoPesaje = new HashSet<MovimientoPesaje>();
        }
    
        public int PesajeId { get; set; }
        public int ConductorId { get; set; }
        public int VehiculoId { get; set; }
        public int AutorizacionId { get; set; }
        public string Observacion { get; set; }
        public short Estado { get; set; }
        public System.DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public Nullable<decimal> Bruto { get; set; }
        public Nullable<decimal> Tara { get; set; }
        public Nullable<decimal> Neto { get; set; }
        public Nullable<int> NaveId { get; set; }
        public int TipoContenedorId { get; set; }
        public string TipoMercancia { get; set; }
        public string CodSeguridad { get; set; }
        public string CodContenedor { get; set; }
        public string Tipo { get; set; }
        public int Bultos { get; set; }
        public Nullable<int> Tarja { get; set; }
        public Nullable<System.DateTime> HoraGancho { get; set; }
    
        public virtual ICollection<AuditoriaPesaje> AuditoriaPesaje { get; set; }
        public virtual Autorizacion Autorizacion { get; set; }
        public virtual Conductor Conductor { get; set; }
        public virtual ICollection<GuiaRemision> GuiaRemision { get; set; }
        public virtual ICollection<MovimientoPesaje> MovimientoPesaje { get; set; }
        public virtual Nave Nave { get; set; }
        public virtual TipoContenedor TipoContenedor { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
