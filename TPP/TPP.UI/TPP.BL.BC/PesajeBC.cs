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
                                                 TipoContenedor = obj.TipoContenedor.Descripcion,
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
        public Pesaje ObtenerPesaje(int PesajeId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Pesaje.FirstOrDefault(X => X.PesajeId == PesajeId);
        }

        public void RegistratPesaje(Pesaje objPesaje)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Pesaje.Add(objPesaje);
            context.SaveChanges();
        }

        public void EliminaPesaje(int PesajeId)
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
