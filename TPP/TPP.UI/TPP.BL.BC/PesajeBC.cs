using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class PesajeBC
    {
        public List<Pesaje> ListarPesaje()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Pesaje.ToList();
        }

        public Pesaje ObtenerPesaje(int PesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Pesaje.FirstOrDefault(X => X.PesajeId == PesajeId);
        }

        public void RegistratPesaje(Pesaje objPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Pesaje.Add(objPesaje);
            context.SaveChanges();
        }

        public void EliminaPesaje(int PesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Pesaje objPesajeOri = context.Pesaje.FirstOrDefault(X => X.PesajeId == PesajeId);
            context.Pesaje.Remove(objPesajeOri);
            context.SaveChanges();
        }

        public void EditarPesaje(Pesaje objPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            Pesaje objPesajeOri = context.Pesaje.FirstOrDefault(X => X.PesajeId == objPesaje.PesajeId);
            
            // creo que no se edita

            context.SaveChanges();

        }
    }
}
