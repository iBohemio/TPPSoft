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
    
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            this.Pesaje = new HashSet<Pesaje>();
        }
    
        public int VehiculoId { get; set; }
        public string Placa { get; set; }
        public string Carrete { get; set; }
        public string Estado { get; set; }
        public Nullable<int> TipoVehiculoId { get; set; }
        public Nullable<int> ConductorId { get; set; }
    
        public virtual ICollection<Pesaje> Pesaje { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }
        public virtual Conductor Conductor { get; set; }
    }
}
