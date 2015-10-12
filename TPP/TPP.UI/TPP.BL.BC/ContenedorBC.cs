using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class ContenedorBC
    {
        public List<Contenedor> ListarContenedor()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Contenedor.ToList();
        }

        public Contenedor ObtenerContenedor(int ContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Contenedor.FirstOrDefault(X => X.ContenedorId == ContenedorId);
        }

        public void RegistratContenedor(Contenedor objContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Contenedor.Add(objContenedor);
            context.SaveChanges();
        }

        public void EliminaContenedor(int ContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Contenedor objContenedorOri = context.Contenedor.FirstOrDefault(X => X.ContenedorId == ContenedorId);
            context.Contenedor.Remove(objContenedorOri);
            context.SaveChanges();
        }

        public void EditarContenedor(Contenedor objContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            Contenedor objContenedorOri = context.Contenedor.FirstOrDefault(X => X.ContenedorId == objContenedor.ContenedorId);
            
            //creo q tampoco se edita


            context.SaveChanges();

        }
    }
}
