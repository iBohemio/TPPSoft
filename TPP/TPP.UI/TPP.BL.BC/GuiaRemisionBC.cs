using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class GuiaRemisionBC
    {
        public GuiaRemision BuscarGuiaRemision(int GuiaRemisionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.GuiaRemision.FirstOrDefault(X => X.GuiaRemisionId == GuiaRemisionId && X.Estado == 1);
        }

        public List<GuiaRemision> ListarGuiaRemision()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.GuiaRemision.Where(X => X.Estado == 1).ToList();
        }

       

        public void RegistrarGuiaRemision(GuiaRemision objGuiaRemision)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.GuiaRemision.Add(objGuiaRemision);
            context.SaveChanges();
        }

        public void EditarGuiaRemision(GuiaRemision objGuiaRemision)
        {
            BDParacasEntities context = new BDParacasEntities();
            GuiaRemision objGuiaRemisionSel = context.GuiaRemision.FirstOrDefault(X => X.GuiaRemisionId == objGuiaRemision.GuiaRemisionId);
            objGuiaRemisionSel.Documento = objGuiaRemision.Documento;
            objGuiaRemisionSel.Bultos = objGuiaRemision.Bultos;
            objGuiaRemisionSel.PesajeId = objGuiaRemision.PesajeId;
            context.SaveChanges();
        }

        public void EliminarGuiaRemision(int GuiaRemisionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            GuiaRemision objGuiaRemisionSel = context.GuiaRemision.FirstOrDefault(X => X.GuiaRemisionId == GuiaRemisionId);
            context.GuiaRemision.Remove(objGuiaRemisionSel);
            context.SaveChanges();
        }

        public void EliminarGuiaInactiva()
        {
            BDParacasEntities context = new BDParacasEntities();
            List<GuiaRemision> LstGuia= context.GuiaRemision.Where(X => X.PesajeId == null).ToList();
            foreach (var guia in LstGuia)
            {
                context.GuiaRemision.Remove(guia);
                context.SaveChanges();
            }
           
        }
    }
}
