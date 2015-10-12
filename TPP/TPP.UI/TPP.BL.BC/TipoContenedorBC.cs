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
            return context.TipoContenedor.ToList();
        }

        public TipoContenedor ObtenerTipoContenedor(int TipoContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TipoContenedor.FirstOrDefault(X => X.TipoContenedorId == TipoContenedorId);
        }

        public void RegistratTipoContenedor(TipoContenedor objTipoContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.TipoContenedor.Add(objTipoContenedor);
            context.SaveChanges();
        }

        public void EliminaTipoContenedor(int TipoContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            TipoContenedor objTipoContenedorOri = context.TipoContenedor.FirstOrDefault(X => X.TipoContenedorId == TipoContenedorId);
            context.TipoContenedor.Remove(objTipoContenedorOri);
            context.SaveChanges();
        }

        public void EditarTipoContenedor(TipoContenedor objTipoContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            TipoContenedor objTipoContenedorOri = context.TipoContenedor.FirstOrDefault(X => X.TipoContenedorId == objTipoContenedor.TipoContenedorId);
            objTipoContenedorOri.Descripcion = objTipoContenedor.Descripcion;
            objTipoContenedorOri.Estado = objTipoContenedor.Estado;
            context.SaveChanges();

        }
    }
}
