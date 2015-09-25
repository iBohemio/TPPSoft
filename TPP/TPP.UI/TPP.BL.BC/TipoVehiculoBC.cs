using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class TipoVehiculoBC
    {
        public TipoVehiculo BuscarTipoVehiculo(int TipoVehiculoId)
        {
            BDParacasEntity context = new BDParacasEntity();
            return context.TipoVehiculo.FirstOrDefault(X => X.TipoVehiculoId == TipoVehiculoId);
        }

        public List<TipoVehiculo> ListarTipoVehiculo()
        {
            BDParacasEntity context = new BDParacasEntity();
            return context.TipoVehiculo.ToList();
        }


        public void RegistrarTipoVehiculo(TipoVehiculo objTipoVehiculo)
        {
            BDParacasEntity context = new BDParacasEntity();
            context.TipoVehiculo.Add(objTipoVehiculo);
            context.SaveChanges();
        }

        public void EditarTipoVehiculo(TipoVehiculo objTipoVehiculo)
        {
            BDParacasEntity context = new BDParacasEntity();
            TipoVehiculo objTipoVehiculoSel = context.TipoVehiculo.FirstOrDefault(X => X.TipoVehiculoId == objTipoVehiculo.TipoVehiculoId);
            objTipoVehiculoSel.Codigo = objTipoVehiculo.Codigo;
            objTipoVehiculoSel.Nombre = objTipoVehiculo.Nombre;
            objTipoVehiculoSel.PesoMaximo = objTipoVehiculo.PesoMaximo;
            context.SaveChanges();
        }

        public void EliminarTipoVehiculo(int TipoVehiculoId)
        {
            BDParacasEntity context = new BDParacasEntity();
            TipoVehiculo objTipoVehiculoSel = context.TipoVehiculo.FirstOrDefault(X => X.TipoVehiculoId == TipoVehiculoId);
            context.TipoVehiculo.Remove(objTipoVehiculoSel);
            context.SaveChanges();
        }
    }
}
