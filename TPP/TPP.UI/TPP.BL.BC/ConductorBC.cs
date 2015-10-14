using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class ConductorBC
    {
        public List<Conductor> ListarConductor()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Conductor.Where(X => X.Estado == 1).ToList();
        }

        public Conductor BuscarConductor(int ConductorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Conductor.FirstOrDefault(X => X.ConductorId == ConductorId && X.Estado == 1);
        }

        public void RegistrarConductor(Conductor objConductor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Conductor.Add(objConductor);
            context.SaveChanges();
        }

        public void EliminarConductor(int ConductorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Conductor objConductorSel = context.Conductor.FirstOrDefault(X => X.ConductorId == ConductorId);
            objConductorSel.Estado = 0;
            context.SaveChanges();
        }

        public void EditarConductor(Conductor objConductor)
        {
            BDParacasEntities context = new BDParacasEntities();
            Conductor objConductorSel = context.Conductor.FirstOrDefault(X => X.ConductorId == objConductor.ConductorId && X.Estado==1);
            objConductorSel.ApellidoMaterno = objConductor.ApellidoMaterno;
            objConductorSel.ApellidoPaterno = objConductor.ApellidoPaterno;
            objConductorSel.Nombres = objConductor.Nombres;
            objConductorSel.NroBrevete = objConductor.NroBrevete;    
            context.SaveChanges();

        }

        public List<Conductor> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Conductor.Where(X => X.Nombres.Contains(Nombre)).ToList();
        }

    }
}
