using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class VehiculoBC
    {
        public Vehiculo BuscarVehiculo(int VehiculoId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Vehiculo.FirstOrDefault(X => X.VehiculoId == VehiculoId);
        }

        public List<Vehiculo> ListarVehiculo()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Vehiculo.ToList();
        }


        public void RegistrarVehiculo(Vehiculo objVehiculo)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Vehiculo.Add(objVehiculo);
            context.SaveChanges();
        }

        public void EditarVehiculo(Vehiculo objVehiculo)
        {
            BDParacasEntities context = new BDParacasEntities();
            Vehiculo objVehiculoSel = context.Vehiculo.FirstOrDefault(X => X.VehiculoId == objVehiculo.VehiculoId);
            objVehiculoSel.Placa = objVehiculo.Placa;
            objVehiculoSel.Carrete = objVehiculo.Carrete;
            objVehiculoSel.TipoVehiculoId = objVehiculo.TipoVehiculoId;
            objVehiculoSel.ConductorId = objVehiculo.ConductorId;
            context.SaveChanges();
        }

        public void EliminarVehiculo(int VehiculoId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Vehiculo objVehiculoSel = context.Vehiculo.FirstOrDefault(X => X.VehiculoId == VehiculoId);
            context.Vehiculo.Remove(objVehiculoSel);
            context.SaveChanges();
        }
    }
}
