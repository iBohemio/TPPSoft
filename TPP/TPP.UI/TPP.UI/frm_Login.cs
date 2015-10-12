using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPP.DL.DataModel;
using TPP.BL.BC;
namespace TPP.UI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        public delegate void EnviarDatos(Usuario UsuarioObj);
        public EnviarDatos MiDelegado;

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
        private void ValidarUsuario()
        {
            Usuario objUsuario = new Usuario();
            UsuarioBC UsuarioBC = new UsuarioBC();
            objUsuario.Codigo = txtUsuario.Text;
            objUsuario.Password = txtContrasenia.Text;
            if (UsuarioBC.ValidarUsuario(objUsuario) != null)
            {
                objUsuario = UsuarioBC.ValidarUsuario(objUsuario);
                MiDelegado(objUsuario);
                this.Dispose();
            }
            else
            {
                lblMensaje.Text = "Datos Incorrectos.";
                lblMensaje.Visible = true;
                txtUsuario.Focus();
                return;
            }
        }

        bool DatosValidos()
        {
            if(txtUsuario.Text.Trim().Length==0)
            {
                epForm.SetError(txtUsuario, "Ingrese Usuario");
                return false;
            }
            else if(txtContrasenia.Text.Trim().Length==0)
            {
                epForm.Clear();
                epForm.SetError(txtContrasenia, "Ingrese Contraseña");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                epForm.Clear();
                ValidarUsuario();
            }   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarUsuario();
            }
        }
    }
}
