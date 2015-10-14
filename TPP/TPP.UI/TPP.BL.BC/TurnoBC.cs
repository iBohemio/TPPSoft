using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class TurnoBC
    {
        public Turno BuscarTurno(int TurnoId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Turno.FirstOrDefault(X => X.TurnoId == TurnoId && X.Estado == 1);
        }

        public List<Turno> ListarTurno()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Turno.Where(X => X.Estado == 1).ToList();
        }


        public void RegistrarTurno(Turno objTurno)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Turno.Add(objTurno);
            context.SaveChanges();
        }

        public void EditarTurno(Turno objTurno)
        {
            BDParacasEntities context = new BDParacasEntities();
            Turno objTurnoSel = context.Turno.FirstOrDefault(X => X.TurnoId == objTurno.TurnoId);
            objTurnoSel.Nombre = objTurno.Nombre;
            objTurnoSel.HoraInicio = objTurno.HoraInicio;
            objTurnoSel.MinutoInicio = objTurno.MinutoInicio;
            objTurnoSel.HoraFin = objTurno.HoraFin;
            objTurnoSel.MinutoFin = objTurno.MinutoFin;
            context.SaveChanges();
        }

        public void EliminarTurno(int TurnoId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Turno objTurnoSel = context.Turno.FirstOrDefault(X => X.TurnoId == TurnoId);
            objTurnoSel.Estado = 0;
            context.SaveChanges();
        }


        public List<Turno> Filtro(String Nombre)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Turno.Where(X => X.Nombre.Contains(Nombre)).ToList();
        }
    }
}
