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
