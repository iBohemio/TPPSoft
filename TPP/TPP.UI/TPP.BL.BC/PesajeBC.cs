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

        public IEnumerable<Object> PesajeListarCompleto()
        {
            BDParacasEntities context = new BDParacasEntities();
            IEnumerable<object> LstPesaje = (from obj in context.Pesaje
                                             select new
                                             {
                                                 PesajeId = obj.PesajeId,
                                                 Conductor = obj.Conductor.Nombres,
                                                 Vehiculo = obj.Vehiculo.Placa,
                                                 Autorizacion = obj.Autorizacion.Codigo,
                                                 Observacion = obj.Observacion,
                                                 Estado = obj.Estado,
                                                 Fecha = obj.Fecha,
                                                 Usuario = obj.Usuario.Codigo,
                                                 Bruto = obj.Bruto,
                                                 Tara = obj.Tara,
                                                 Neto = obj.Neto,
                                                 Nave = obj.Nave.Nombre,
                                                 TipoMercancia = obj.TipoMercancia,
                                                 CodSeguridad = obj.CodSeguridad,
                                                 CodContenedor = obj.CodContenedor,
                                                 Tipo = obj.Tipo,
                                                 Bultos = obj.Bultos,
                                                 Tarja = obj.Tarja,
                                                 HoraGancho = obj.HoraGancho


                                             }).ToList();
            return LstPesaje;
        }
        
        public int BuscarUltimoIdPesaje()
        {
              using (var ctx = new BDParacasEntities())
            {
                int IdPesaje = ctx.Database.SqlQuery<int>("select top 1 PesajeId from Pesaje order by PesajeId desc").FirstOrDefault<int>();
                return IdPesaje;
              }
            
        }
        public Pesaje BuscarPesaje(int PesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Pesaje.FirstOrDefault(X => X.PesajeId == PesajeId);
        }

        public void RegistrarPesaje(Pesaje objPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Pesaje.Add(objPesaje);
            context.SaveChanges();
        }

        public void EliminarPesaje(int PesajeId)
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
