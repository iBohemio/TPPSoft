using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class UsuarioBC
    {
       
     
        public Usuario ValidarUsuario(Usuario objUsuario)
        {            
            BDParacasEntities context = new BDParacasEntities();
            return context.Usuario.FirstOrDefault(X => X.Clave == objUsuario.Clave &&
                X.Usuario1 == objUsuario.Usuario1);
        }

        public Usuario BuscarUsuario(int UsuarioId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Usuario.FirstOrDefault(X => X.UsuarioID == UsuarioId);
        }


        public IEnumerable<Object> UsuarioListarCompleto()
        {
            BDParacasEntities context = new BDParacasEntities();
            IEnumerable<Object> LstUsuario = (from obj in context.Usuario
                                                select new
                                                {
                                                    UsuarioId = obj.UsuarioID,
                                                    Nombres = obj.Usuario1,
                                                    RolId = obj.RolUsuarioId,
                                                    Rol = obj.RolUsuario.Descripcion
                                                }).ToList();
            return LstUsuario;
        }

        public void RegistrarUsuario(Usuario objUsuario)
        {
            BDParacasEntities context = new BDParacasEntities();
            context.Usuario.Add(objUsuario);
            context.SaveChanges();
        }

        public void EditarUsuario(Usuario objUsuario)
        {
            BDParacasEntities context = new BDParacasEntities();
            Usuario objUsuarioSel = context.Usuario.FirstOrDefault(X => X.UsuarioID == objUsuario.UsuarioID);
            objUsuarioSel.Usuario1 = objUsuario.Usuario1;
            objUsuarioSel.Clave = objUsuario.Clave;
            objUsuarioSel.RolUsuarioId = objUsuario.RolUsuarioId;
            context.SaveChanges();
        }
        
        public void EliminarUsuario(int UsuarioId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Usuario objUsuarioSel = context.Usuario.FirstOrDefault(X => X.UsuarioID == UsuarioId);
            context.Usuario.Remove(objUsuarioSel);
            context.SaveChanges();
        }
    }
}
