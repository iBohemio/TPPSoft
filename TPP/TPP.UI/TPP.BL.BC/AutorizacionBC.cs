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
        public IEnumerable<Object> AutorizacionListarCompleto()
        {
            BDParacasEntities context = new BDParacasEntities();
            IEnumerable<object> LstAutorizacion = (from obj in context.Autorizacion
                                             select new
                                             {
                                                 AutorizacionId = obj.AutorizacionId,
                                                 Codigo = obj.Codigo,
                                                 EmbalajeId = obj.EmbalajeId,
                                                 Embalaje = obj.Embalaje.Codigo,
                                                 OperacionId = obj.OperacionId,
                                                 Operacion = obj.Operacion.Codigo,
                                                 Peso = obj.Peso,
                                                 NroBultos = obj.NroBultos,
                                                 Estado = obj.Estado,
                                                 Fecha = obj.Fecha,
                                                 UsuarioId = obj.UsuarioId,
                                                 Usuario = obj.Usuario.Codigo,
                                                 NaveId = obj.NaveId,
                                                 Nave = obj.Nave.Nombre,
                                                 Producto = obj.Producto,
                                                 Tipo = obj.Tipo
                                             }).ToList();
            return LstAutorizacion;
        }

        public Autorizacion BuscarAutorizacion(int AutorizacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Autorizacion.FirstOrDefault(X => X.AutorizacionId == AutorizacionId);
        }

        public void RegistrarAutorizacion(Autorizacion objAutorizacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Autorizacion.Add(objAutorizacion);
            context.SaveChanges();
        }

        public void EliminarAutorizacion(int AutorizacionId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Autorizacion objAutorizacionSel = context.Autorizacion.FirstOrDefault(X => X.AutorizacionId == AutorizacionId);
            context.Autorizacion.Remove(objAutorizacionSel);
            context.SaveChanges();
        }

        public void EditarAutorizacion(Autorizacion objAutorizacion)
        {
            BDParacasEntities context = new BDParacasEntities();
            Autorizacion objAutorizacionSel = context.Autorizacion.FirstOrDefault(X => X.AutorizacionId == objAutorizacion.AutorizacionId);
            objAutorizacionSel.Codigo = objAutorizacion.Codigo;
            objAutorizacionSel.EmbalajeId = objAutorizacion.EmbalajeId;
            objAutorizacionSel.OperacionId = objAutorizacion.OperacionId;
            objAutorizacionSel.Peso = objAutorizacion.Peso;
            objAutorizacionSel.NroBultos = objAutorizacion.NroBultos;
            objAutorizacionSel.Fecha = objAutorizacion.Fecha;
            objAutorizacionSel.UsuarioId = objAutorizacion.UsuarioId;
            objAutorizacionSel.NaveId = objAutorizacion.NaveId;
            objAutorizacionSel.Producto = objAutorizacion.Producto;
            objAutorizacionSel.Tipo = objAutorizacion.Tipo;
            objAutorizacionSel.Estado = objAutorizacion.Estado;
            context.SaveChanges();

        }

        public IEnumerable<Object> FiltrarContenedores(String codigo)
        {
            BDParacasEntities context = new BDParacasEntities();
            Autorizacion objAutoOri = context.Autorizacion.FirstOrDefault(X => X.Codigo.Contains(codigo));
            IEnumerable<object> Contenedores = (from obj in context.Contenedor
                                                where obj.NaveId.Equals(objAutoOri.NaveId)
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
                                                    FechaIzaje = obj.FechaIzaje,
                                                    FechaMuelle = obj.FechaMuelle,
                                                    FechaBarco = obj.FechaBarco,
                                                    TipoContenedor = obj.TipoContenedor.Descripcion,
                                                    TamanioContenedor = obj.TamanioContenedor.Descripcion,
                                                    EIR = obj.EIR,
                                                    Ubicacion = obj.Ubicacion,
                                                    Fecha = obj.Fecha,
                                                    Nave = obj.Nave.Nombre

                                                }).ToList();
            return Contenedores;
        }
    }
}
