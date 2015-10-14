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
            return context.Embalaje.Where(X => X.Estado == 1).ToList();
        }

        public Embalaje BuscarEmbalaje(int EmbalajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Embalaje.FirstOrDefault(X => X.EmbalajeId == EmbalajeId && X.Estado == 1);
        }

        public void RegistrarEmbalaje(Embalaje objEmbalaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Embalaje.Add(objEmbalaje);
            context.SaveChanges();
        }

        public void EliminarEmbalaje(int EmbalajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Embalaje objEmbalajeSel = context.Embalaje.FirstOrDefault(X => X.EmbalajeId == EmbalajeId);
            objEmbalajeSel.Estado = 0;
            context.SaveChanges();
        }

        public void EditarEmbalaje(Embalaje objEmbalaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            Embalaje objConductorSel = context.Embalaje.FirstOrDefault(X => X.EmbalajeId == objEmbalaje.EmbalajeId && X.Estado == 1);
            objConductorSel.Codigo = objEmbalaje.Codigo;
            objConductorSel.Descripcion = objEmbalaje.Descripcion;      
            context.SaveChanges();
        }

        public List<Embalaje> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Embalaje.Where(X => X.Descripcion.Contains(Nombre)).ToList();
        }
    }
}
