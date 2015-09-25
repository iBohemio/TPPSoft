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
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Datos Incorrectos.";
                lblMensaje.Visible = true;
                txtUsuario.Focus();
                return;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
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
