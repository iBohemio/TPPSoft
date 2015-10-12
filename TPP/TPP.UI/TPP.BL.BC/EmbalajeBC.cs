using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class EmbalajeBC
    {
        public List<Embalaje> ListarEmbalaje()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Embalaje.ToList();
        }

        public Embalaje ObtenerEmbalaje(int EmbalajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Embalaje.FirstOrDefault(X => X.EmbalajeId == EmbalajeId);
        }

        public void RegistratEmbalaje(Embalaje objEmbalaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Embalaje.Add(objEmbalaje);
            context.SaveChanges();
        }

        public void EliminarEmbalaje(int EmbalajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Embalaje objEmbalajeOri = context.Embalaje.FirstOrDefault(X => X.EmbalajeId == EmbalajeId);
            context.Embalaje.Remove(objEmbalajeOri);
            context.SaveChanges();
        }

        public void EditarEmbalaje(Embalaje objEmbalaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            Embalaje objEmbalajeOri = context.Embalaje.FirstOrDefault(X => X.EmbalajeId == objEmbalaje.EmbalajeId);            
            objEmbalajeOri.Codigo = objEmbalaje.Codigo;
            objEmbalajeOri.Descripcion = objEmbalaje.Descripcion;
            objEmbalajeOri.Estado = objEmbalaje.Estado; // no se si este va             
            context.SaveChanges();

        }
    }
}
