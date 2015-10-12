using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class AutorizacionBC
    {
        public List<Autorizacion> ListarAutorizacion()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Autorizacion.ToList();
        }

        public Autorizacion ObtenerAutorizacion(int AutorizacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Autorizacion.FirstOrDefault(X => X.AutorizacionId == AutorizacionId);
        }

        public void RegistratAutorizacion(Autorizacion objAutorizacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Autorizacion.Add(objAutorizacion);
            context.SaveChanges();
        }

        public void EliminaAutorizacion(int AutorizacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Autorizacion objAutorizacionOri = context.Autorizacion.FirstOrDefault(X => X.AutorizacionId == AutorizacionId);
            context.Autorizacion.Remove(objAutorizacionOri);
            context.SaveChanges();
        }

        public void EditarAutorizacion(Autorizacion objAutorizacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            Autorizacion objAutorizacionOri = context.Autorizacion.FirstOrDefault(X => X.AutorizacionId == objAutorizacion.AutorizacionId);
          
            //creo q no se edita pero avisas para completar
                       
            context.SaveChanges();

        }

    }
}
