using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class NaveBC
    {
        public List<Nave> ListarNave()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Nave.ToList();
        }

        public Nave ObtenerNave(int NaveId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Nave.FirstOrDefault(X => X.NaveId == NaveId);
        }

        public void RegistratNave(Nave objNave)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Nave.Add(objNave);
            context.SaveChanges();
        }

        public void EliminaNave(int NaveId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Nave objNaveOri = context.Nave.FirstOrDefault(X => X.NaveId == NaveId);
            context.Nave.Remove(objNaveOri);
            context.SaveChanges();
        }

        public void EditarNave(Nave objNave)
        {
            BDParacasEntities context = new BDParacasEntities();
            Nave objNaveOri = context.Nave.FirstOrDefault(X => X.NaveId == objNave.NaveId);
            objNaveOri.Nombre = objNave.Nombre;
            objNaveOri.PesoTotal = objNave.PesoTotal;
            objNaveOri.Estado = objNave.Estado;           
            context.SaveChanges();

        }

        public List<Nave> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Nave.Where(X => X.Nombre.Contains(Nombre)).ToList();
        }
    }
}
