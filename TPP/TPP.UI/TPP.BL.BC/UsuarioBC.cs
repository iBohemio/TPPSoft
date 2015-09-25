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
            BDParacasEntity context = new BDParacasEntity();
            return context.Usuario.FirstOrDefault(X => X.Password == objUsuario.Password &&
                X.Codigo == objUsuario.Codigo);
        }

        public Usuario BuscarUsuario(int UsuarioId)
        {
            BDParacasEntity context = new BDParacasEntity();
            return context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId);
        }


        public IEnumerable<Object> UsuarioListarCompleto()
        {
            BDParacasEntity context = new BDParacasEntity();
            IEnumerable<Object> LstUsuario = (from obj in context.Usuario
                                                select new
                                                {
                                                    UsuarioId = obj.UsuarioId,
                                                    Nombres = obj.Codigo,
                                                    RolId=obj.RolId,
                                                    Rol = obj.Rol.Descripcion
                                                }).ToList();
            return LstUsuario;
        }

        public void RegistrarUsuario(Usuario objUsuario)
        {
            BDParacasEntity context = new BDParacasEntity();
            context.Usuario.Add(objUsuario);
            context.SaveChanges();
        }

        public void EditarUsuario(Usuario objUsuario)
        {
            BDParacasEntity context = new BDParacasEntity();
            Usuario objUsuarioSel = context.Usuario.FirstOrDefault(X => X.UsuarioId == objUsuario.UsuarioId);
            objUsuarioSel.Codigo = objUsuario.Codigo;
            objUsuarioSel.Password = objUsuario.Password;
            objUsuarioSel.RolId = objUsuario.RolId;
            context.SaveChanges();
        }
        
        public void EliminarUsuario(int UsuarioId)
        {
            BDParacasEntity context = new BDParacasEntity();
            Usuario objUsuarioSel = context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId);
            context.Usuario.Remove(objUsuarioSel);
            context.SaveChanges();
        }
    }
}
