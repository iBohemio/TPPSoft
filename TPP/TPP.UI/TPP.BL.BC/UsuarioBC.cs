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
            return context.Usuario.FirstOrDefault(X => X.Password == objUsuario.Password &&
                X.Codigo == objUsuario.Codigo && X.Estado==1);
        }

        public Usuario BuscarUsuario(int UsuarioId)
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId && X.Estado == 1);
        }


        public IEnumerable<Object> UsuarioListarCompleto()
        {
            BDParacasEntities context = new BDParacasEntities();
            IEnumerable<Object> LstUsuario = (from obj in context.Usuario where obj.Estado==1
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
            BDParacasEntities context = new BDParacasEntities();
            context.Usuario.Add(objUsuario);
            context.SaveChanges();
        }

        public void EditarUsuario(Usuario objUsuario)
        {
            BDParacasEntities context = new BDParacasEntities();
            Usuario objUsuarioSel = context.Usuario.FirstOrDefault(X => X.UsuarioId == objUsuario.UsuarioId && X.Estado ==1);
            objUsuarioSel.Codigo = objUsuario.Codigo;
            objUsuarioSel.Password = objUsuario.Password;
            objUsuarioSel.RolId = objUsuario.RolId;
            context.SaveChanges();
        }
        
        public void EliminarUsuario(int UsuarioId)
        {
            BDParacasEntities context = new BDParacasEntities();
            Usuario objUsuarioSel = context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId);
            objUsuarioSel.Estado = 0;
            context.SaveChanges();
        }
    }
}
