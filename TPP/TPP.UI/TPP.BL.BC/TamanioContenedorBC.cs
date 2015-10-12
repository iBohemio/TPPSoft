using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class TamanioContenedorBC
    {
        public List<TamanioContenedor> ListarTamanioContenedor()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TamanioContenedor.Where(X => X.Estado == 1).ToList();
        }

        public TamanioContenedor BuscarTamanioContenedor(int TamanioContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TamanioContenedor.FirstOrDefault(X => X.TamanioContenedorId == TamanioContenedorId && X.Estado == 1);
        }

        public void RegistrarTamanioContenedor(TamanioContenedor objTamanioContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.TamanioContenedor.Add(objTamanioContenedor);
            context.SaveChanges();
        }

        public void EliminarTamanioContenedor(int TamanioContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            TamanioContenedor objTamanioContenedorSel = context.TamanioContenedor.FirstOrDefault(X => X.TamanioContenedorId == TamanioContenedorId);
            objTamanioContenedorSel.Estado = 0;
            context.SaveChanges();
        }

        public void EditarTamanioContenedor(TamanioContenedor objTamanioContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            TamanioContenedor objTamanioContenedorSel = context.TamanioContenedor.FirstOrDefault(X => X.TamanioContenedorId == objTamanioContenedor.TamanioContenedorId && X.Estado == 1);
            objTamanioContenedorSel.Descripcion = objTamanioContenedor.Descripcion;
            context.SaveChanges();
        }
    }
}
