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
            return context.Vehiculo.FirstOrDefault(X => X.VehiculoId == VehiculoId && X.Estado==1);
        }

        public IEnumerable<Object> ListarVehiculo()
        {
            BDParacasEntities context = new BDParacasEntities();
            IEnumerable<Object> LstVehiculo = (from obj in context.Vehiculo
                                              where obj.Estado == 1
                                              select new
                                              {
                                                  VehiculoId = obj.VehiculoId,
                                                  Placa = obj.Placa,
                                                  Carrete = obj.Carrete,
                                                  Estado = obj.Estado,
                                                  TipoVehiculoId = obj.TipoVehiculoId,
                                                  TipoVehiculo = obj.TipoVehiculo.Nombre
                                              }).ToList();
            return LstVehiculo;
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
        public List<Vehiculo> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Vehiculo.Where(X => X.Placa.Contains(Nombre) && X.Estado == 1).ToList();
        }
    }
}
