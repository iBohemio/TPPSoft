using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;

namespace TPP.BL.BC
{
    public class AuditoriaPesajeBC
    {
        public List<AuditoriaPesaje> ListarAuditoriaPesaje()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.AuditoriaPesaje.ToList();
        }

        public AuditoriaPesaje ObtenerAuditoriaPesaje(int AuditoriaPesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.AuditoriaPesaje.FirstOrDefault(X => X.AuditoriaPesajeId == AuditoriaPesajeId);
        }

        public void RegistratAuditoriaPesaje(AuditoriaPesaje objAuditoriaPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.AuditoriaPesaje.Add(objAuditoriaPesaje);
            context.SaveChanges();
        }

        public void EliminaAuditoriaPesaje(int AuditoriaPesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            AuditoriaPesaje objAuditoriaPesajeOri = context.AuditoriaPesaje.FirstOrDefault(X => X.AuditoriaPesajeId == AuditoriaPesajeId);
            context.AuditoriaPesaje.Remove(objAuditoriaPesajeOri);
            context.SaveChanges();
        }

        public void EditarAuditoriaPesaje(AuditoriaPesaje objAuditoriaPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            AuditoriaPesaje objAuditoriaPesajeOri = context.AuditoriaPesaje.FirstOrDefault(X => X.AuditoriaPesajeId == objAuditoriaPesaje.AuditoriaPesajeId);
            objAuditoriaPesajeOri.Fecha = objAuditoriaPesaje.Fecha;
            objAuditoriaPesajeOri.PesajeId = objAuditoriaPesaje.PesajeId;
            objAuditoriaPesajeOri.UsuarioId = objAuditoriaPesaje.UsuarioId;
            context.SaveChanges();

        }
    }
}
