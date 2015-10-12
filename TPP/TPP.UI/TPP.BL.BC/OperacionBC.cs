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
            return context.Operacion.ToList();
        }

        public Operacion ObtenerOperacion(int OperacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Operacion.FirstOrDefault(X => X.OperacionId == OperacionId);
        }

        public void RegistratOperacion(Operacion objOperacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Operacion.Add(objOperacion);
            context.SaveChanges();
        }

        public void EliminarOperacion(int OperacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Operacion objOperacionOri = context.Operacion.FirstOrDefault(X => X.OperacionId == OperacionId);
            context.Operacion.Remove(objOperacionOri);
            context.SaveChanges();
        }

        public void EditarOperacion(Operacion objOperacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            Operacion objOperacionOri = context.Operacion.FirstOrDefault(X => X.OperacionId == objOperacion.OperacionId);
            objOperacionOri.Codigo = objOperacion.Codigo;
            objOperacionOri.Descripcion = objOperacion.Descripcion;
            objOperacionOri.Estado = objOperacion.Estado; // no se si este va      
            
            context.SaveChanges();

        }
    }
}
