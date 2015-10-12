using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class TipoContenedorBC
    {
        public List<TipoContenedor> ListarTipoContenedor()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TipoContenedor.Where(X => X.Estado == 1).ToList();
        }

        public TipoContenedor BuscarTipoContenedor(int TipoContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TipoContenedor.FirstOrDefault(X => X.TipoContenedorId == TipoContenedorId && X.Estado == 1);
        }

        public void RegistrarTipoContenedor(TipoContenedor objTipoContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.TipoContenedor.Add(objTipoContenedor);
            context.SaveChanges();
        }

        public void EliminarTipoContenedor(int TipoContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            TipoContenedor objTipoContenedorSel = context.TipoContenedor.FirstOrDefault(X => X.TipoContenedorId == TipoContenedorId);
            objTipoContenedorSel.Estado = 0;
            context.SaveChanges();
        }

        public void EditarTipoContenedor(TipoContenedor objTipoContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            TipoContenedor objTipoContenedorSel = context.TipoContenedor.FirstOrDefault(X => X.TipoContenedorId == objTipoContenedor.TipoContenedorId && X.Estado == 1);
            objTipoContenedorSel.Descripcion = objTipoContenedor.Descripcion;
            context.SaveChanges();
        }
    }
}
