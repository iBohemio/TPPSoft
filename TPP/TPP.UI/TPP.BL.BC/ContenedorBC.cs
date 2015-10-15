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

        public Contenedor BuscarContenedor(int ContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Contenedor.FirstOrDefault(X => X.ContenedorId == ContenedorId && X.Estado==1);
        }

        public void RegistrarContenedor(Contenedor objContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Contenedor.Add(objContenedor);
            context.SaveChanges();
        }

        public void EliminarContenedor(int ContenedorId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Contenedor objContenedorSel = context.Contenedor.FirstOrDefault(X => X.ContenedorId == ContenedorId);
            context.Contenedor.Remove(objContenedorSel);
            context.SaveChanges();
        }

        public void EditarContenedor(Contenedor objContenedor)
        {
            BDParacasEntities context = new BDParacasEntities();
            Contenedor objContenedorSel = context.Contenedor.FirstOrDefault(X => X.ContenedorId == objContenedor.ContenedorId);

            objContenedorSel.Codigo = objContenedor.Codigo;
            objContenedorSel.Embarcadero = objContenedor.Embarcadero;
            objContenedorSel.PesoManifiesto = objContenedor.PesoManifiesto;
            objContenedorSel.AgenteAduana = objContenedor.AgenteAduana;
            objContenedorSel.TipoMovimiento = objContenedor.TipoMovimiento;
            objContenedorSel.Tara = objContenedor.Tara;
            objContenedorSel.TamanoContenedorId = objContenedor.TamanoContenedorId;
            objContenedorSel.TipoContenedorId = objContenedor.TipoContenedorId;
            objContenedorSel.NumeroViaje = objContenedor.NumeroViaje;
            objContenedorSel.EIR = objContenedor.EIR;
            objContenedorSel.Estado = objContenedor.Estado;
            objContenedorSel.PrecintoAduanero = objContenedor.PrecintoAduanero;
            objContenedorSel.Precinto1 = objContenedor.Precinto1;
            objContenedorSel.Precinto2 = objContenedor.Precinto2;
            objContenedorSel.Precinto3 = objContenedor.Precinto3;
            objContenedorSel.Ubicacion = objContenedor.Ubicacion;
            objContenedorSel.NaveId = objContenedor.NaveId;
            objContenedorSel.FechaIzaje = objContenedor.FechaIzaje;
            objContenedorSel.FechaBarco = objContenedor.FechaBarco;
            objContenedorSel.FechaMuelle = objContenedor.FechaMuelle;
            objContenedorSel.Autorizacion = objContenedor.Autorizacion;
            objContenedorSel.Fecha = objContenedor.Fecha;
            context.SaveChanges();
        }

        public IEnumerable<Object> ContenedorListarCompleto()
        {
            BDParacasEntities context = new BDParacasEntities();
            IEnumerable<object> LstContenedor = (from obj in context.Contenedor
                                                 select new
                                                 {
                                                     ContenedorId = obj.ContenedorId,
                                                     Estado = obj.Estado,
                                                     Embarcadero = obj.Embarcadero,
                                                     AgenteAduana = obj.AgenteAduana,
                                                     TipoMovimiento = obj.TipoMovimiento,
                                                     Codigo = obj.Codigo,
                                                     Tara = obj.Tara,
                                                     NumeroViaje = obj.NumeroViaje,
                                                     PesoManifiesto = obj.PesoManifiesto,
                                                     PrecintoAduanero = obj.PrecintoAduanero,
                                                     Precinto1 = obj.Precinto1,
                                                     Precinto2 = obj.Precinto2,
                                                     Precinto3 = obj.Precinto3,
                                                     FechaMuelle = obj.FechaMuelle,
                                                     FechaBarco = obj.FechaBarco,
                                                     TipoContenedor = obj.TipoContenedor.Descripcion,
                                                     TamanioContenedor = obj.TamanioContenedor.Descripcion,
                                                     EIR = obj.EIR,
                                                     Ubicacion = obj.Ubicacion,
                                                     Fecha = obj.Fecha,
                                                     Nave = obj.Nave.Nombre


                                                 }).ToList();
            return LstContenedor;
        }

    }
}
