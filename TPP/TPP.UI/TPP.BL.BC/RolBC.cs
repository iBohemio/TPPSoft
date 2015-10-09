using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.DL.DataModel;
namespace TPP.BL.BC
{
    public class RolBC
    {
        public List<Rol> ListarRol()
        {
            BDParacasEntities context = new BDParacasEntities();
            return context.Rol.ToList();
        }
    }
}
