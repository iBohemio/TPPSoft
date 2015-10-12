using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class OperacionBC
    {
        public List<Operacion> ListarOperacion()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Operacion.Where(X => X.Estado == 1).ToList();
        }

        public Operacion BuscarOperacion(int OperacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Operacion.FirstOrDefault(X => X.OperacionId == OperacionId && X.Estado == 1);
        }

        public void RegistrarOperacion(Operacion objOperacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Operacion.Add(objOperacion);
            context.SaveChanges();
        }

        public void EliminarOperacion(int OperacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Operacion objOperacionSel = context.Operacion.FirstOrDefault(X => X.OperacionId == OperacionId);
            objOperacionSel.Estado = 0;
            context.SaveChanges();
        }

        public void EditarOperacion(Operacion objOperacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            Operacion objOperacionSel = context.Operacion.FirstOrDefault(X => X.OperacionId == objOperacion.OperacionId && X.Estado == 1);
            objOperacionSel.Codigo = objOperacion.Codigo;
            objOperacionSel.Descripcion = objOperacion.Descripcion;            
            context.SaveChanges();

        }
    }
}
