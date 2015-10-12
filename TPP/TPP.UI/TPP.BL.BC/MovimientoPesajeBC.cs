using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;

namespace TPP.BL.BC
{
    public class MovimientoPesajeBC
    {
        public List<MovimientoPesaje> ListarMovimientoPesaje()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.MovimientoPesaje.ToList();
        }

        public MovimientoPesaje ObtenerMovimientoPesaje(int MovimientoPesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.MovimientoPesaje.FirstOrDefault(X => X.MovimientoPesajeId == MovimientoPesajeId);
        }

        public void RegistratMovimientoPesaje(MovimientoPesaje objMovimientoPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.MovimientoPesaje.Add(objMovimientoPesaje);
            context.SaveChanges();
        }

        public void EliminarMovimientoPesaje(int MovimientoPesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            MovimientoPesaje objMovimientoPesajeOri = context.MovimientoPesaje.FirstOrDefault(X => X.MovimientoPesajeId == MovimientoPesajeId);
            context.MovimientoPesaje.Remove(objMovimientoPesajeOri);
            context.SaveChanges();
        }

        public void EditarMovimientoPesaje(MovimientoPesaje objMovimientoPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            MovimientoPesaje objMovimientoPesajeOri = context.MovimientoPesaje.FirstOrDefault(X => X.MovimientoPesajeId == objMovimientoPesaje.MovimientoPesajeId);
            objMovimientoPesajeOri.Estado = objMovimientoPesaje.Estado; // no se si este va
            objMovimientoPesajeOri.Fecha = objMovimientoPesaje.Fecha;
            objMovimientoPesajeOri.PesajeId = objMovimientoPesaje.PesajeId;
            objMovimientoPesajeOri.TipoRepesaje = objMovimientoPesaje.TipoRepesaje;
            objMovimientoPesajeOri.Tipo = objMovimientoPesaje.Tipo;
            objMovimientoPesajeOri.Peso = objMovimientoPesaje.Peso;
            objMovimientoPesajeOri.UsuarioId = objMovimientoPesaje.UsuarioId;

            context.SaveChanges();

        }
    }
}
