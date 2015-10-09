using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPP.UI
{
    public partial class frm_Eje : Form
    {
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int EjeId { get; set; }

        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;

        public String MensajePregunta;
        public String MensajeRespuesta;
        public frm_Eje()
        {
            InitializeComponent();
        }

        private void frm_Eje_Load(object sender, EventArgs e)
        {
            try
            {
                  if(Modo == TypeMode.Registrar)
                {
                    lblEje.Text = "Registrar Eje";
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Estas seguro de registrar el distrito?";
                    MensajeRespuesta = "El distrito se registro satisfactoriamente";
                }
                else if(Modo == TypeMode.Editar)
                {
                    lblEje.Text = "Editar Eje";
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Estas seguro de editar el distrito?";
                    MensajeRespuesta = "El distrito se edito satisfactoriamente";

                    //DistritoBC objDistritoBC = new DistritoBC();
                    //Distrito objDistrito = objDistritoBC.DistritoObtener(DistritoId);
                    //txtNombre.Text = objDistrito.Nombre;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
