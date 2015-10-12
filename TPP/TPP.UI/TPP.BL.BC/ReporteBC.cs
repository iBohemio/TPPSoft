using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;

namespace TPP.BL.BC
{
    public class ReporteBC
    {
        public List<Reporte> ListarReporte()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Reporte.ToList();
        }

        public Reporte ObtenerReporte(int ReporteId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Reporte.FirstOrDefault(X => X.ReporteId == ReporteId);
        }

        public void RegistratReporte(Reporte objReporte)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Reporte.Add(objReporte);
            context.SaveChanges();
        }

        public void EliminaReporte(int ReporteId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Reporte objReporteOri = context.Reporte.FirstOrDefault(X => X.ReporteId == ReporteId);
            context.Reporte.Remove(objReporteOri);
            context.SaveChanges();
        }

        public void EditarReporte(Reporte objReporte)
        {
            BDParacasEntities context = new BDParacasEntities();
            Reporte objReporteOri = context.Reporte.FirstOrDefault(X => X.ReporteId == objReporte.ReporteId);
            objReporteOri.EstadoFiltro = objReporte.EstadoFiltro;
            objReporteOri.Fecha = objReporte.Fecha;
            objReporteOri.TurnoId = objReporte.TurnoId;
            objReporteOri.UsuarioId = objReporte.UsuarioId;
            context.SaveChanges();

        }
    }
}
