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
            return context.TamanioContenedor.ToList();
        }

        public TamanioContenedor ObtenerTamanioContenedor(int TamanioContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.TamanioContenedor.FirstOrDefault(X => X.TamanioContenedorId == TamanioContenedorId);
        }

        public void RegistratTamanioContenedor(TamanioContenedor objTamanioContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.TamanioContenedor.Add(objTamanioContenedor);
            context.SaveChanges();
        }

        public void EliminaTamanioContenedor(int TamanioContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            TamanioContenedor objTamanioContenedorOri = context.TamanioContenedor.FirstOrDefault(X => X.TamanioContenedorId == TamanioContenedorId);
            context.TamanioContenedor.Remove(objTamanioContenedorOri);
            context.SaveChanges();
        }

        public void EditarTamanioContenedor(TamanioContenedor objTamanioContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            TamanioContenedor objTamanioContenedorOri = context.TamanioContenedor.FirstOrDefault(X => X.TamanioContenedorId == objTamanioContenedor.TamanioContenedorId);
            objTamanioContenedorOri.Estado = objTamanioContenedor.Estado;
            objTamanioContenedorOri.Descripcion = objTamanioContenedor.Descripcion;
            context.SaveChanges();

        }
    }
}
