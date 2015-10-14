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
            return context.Nave.Where(X => X.Estado == 1).ToList();
        }

        public Nave BuscarNave(int NaveId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Nave.FirstOrDefault(X => X.NaveId == NaveId && X.Estado == 1);
        }

        public void RegistrarNave(Nave objNave)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Nave.Add(objNave);
            context.SaveChanges();
        }

        public void EliminarNave(int NaveId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Nave objNaveSel = context.Nave.FirstOrDefault(X => X.NaveId == NaveId);
            objNaveSel.Estado = 0;
            context.SaveChanges();
        }

        public void EditarNave(Nave objNave)
        {
            BDParacasEntities context = new BDParacasEntities();
            Nave objNaveSel = context.Nave.FirstOrDefault(X => X.NaveId == objNave.NaveId);
            objNaveSel.Nombre = objNave.Nombre;
            objNaveSel.PesoTotal = objNave.PesoTotal;    
            context.SaveChanges();

        }

        public List<Nave> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Nave.Where(X => X.Nombre.Contains(Nombre)).ToList();
        }
    }
}
