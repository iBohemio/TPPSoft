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
            BDParacasEntities context = new BDParacasEntities();
            return context.TipoVehiculo.FirstOrDefault(X => X.TipoVehiculoId == TipoVehiculoId && X.Estado==1);
        }

        public List<TipoVehiculo> ListarTipoVehiculo()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TipoVehiculo.Where(X=>X.Estado==1).ToList();
        }


        public void RegistrarTipoVehiculo(TipoVehiculo objTipoVehiculo)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.TipoVehiculo.Add(objTipoVehiculo);
            context.SaveChanges();
        }

        public void EditarTipoVehiculo(TipoVehiculo objTipoVehiculo)
        {
            BDParacasEntities context = new BDParacasEntities();
            TipoVehiculo objTipoVehiculoSel = context.TipoVehiculo.FirstOrDefault(X => X.TipoVehiculoId == objTipoVehiculo.TipoVehiculoId);
            objTipoVehiculoSel.Codigo = objTipoVehiculo.Codigo;
            objTipoVehiculoSel.Nombre = objTipoVehiculo.Nombre;
            objTipoVehiculoSel.PesoMaximo = objTipoVehiculo.PesoMaximo;
            context.SaveChanges();
        }

        public void EliminarTipoVehiculo(int TipoVehiculoId)
        {
            BDParacasEntities context = new BDParacasEntities();
            TipoVehiculo objTipoVehiculoSel = context.TipoVehiculo.FirstOrDefault(X => X.TipoVehiculoId == TipoVehiculoId);
            objTipoVehiculoSel.Estado = 0;
            context.SaveChanges();
        }

        public List<TipoVehiculo> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TipoVehiculo.Where(X => X.Nombre.Contains(Nombre) && X.Estado == 1).ToList();
        }
    }
}
