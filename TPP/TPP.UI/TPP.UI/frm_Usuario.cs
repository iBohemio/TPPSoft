using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPP.BL.BC;
using TPP.DL.DataModel;
namespace TPP.UI
{
    public partial class frm_Usuario : Form
    {
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int UsuarioId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;


        public frm_Usuario()
        {
            InitializeComponent();
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                
                RolBC objRolBC = new RolBC();
                cbRol.DataSource = objRolBC.ListarRol();
                cbRol.DisplayMember = "Descripcion";
                cbRol.ValueMember = "RolUsuarioId";
                if(Modo==TypeMode.Registrar)
                {
                    lblUsuario.Text = "Registrar Usuario";
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el usuario?";
                    MensajeRespuesta = "Se registró el usuario satisfactoriamente.";
                }
                else if (Modo==TypeMode.Editar)
                {
                    lblUsuario.Text = "Editar Usuario";
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el usuario?";
                    MensajeRespuesta = "Se editó el usuario satisfactoriamente.";
                    UsuarioBC objUsuarioBC = new UsuarioBC();
                    Usuario objUsuario = objUsuarioBC.BuscarUsuario(UsuarioId);
                    txtUsuario.Text = objUsuario.Codigo;
                    txtContrasenia.Text = objUsuario.Password;
                    cbRol.SelectedValue = objUsuario.RolId;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema esta fuera de servicio", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MensajePregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                UsuarioBC objUsuarioBC = new UsuarioBC();
                Usuario objUsuario = new Usuario();
                if (Modo == TypeMode.Registrar)
                {
                    objUsuario.Codigo = txtUsuario.Text;
                    objUsuario.Password = txtContrasenia.Text;
                    objUsuario.RolId = Convert.ToInt32(cbRol.SelectedValue.ToString());
                    objUsuarioBC.RegistrarUsuario(objUsuario);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Modo == TypeMode.Editar)
                {
                    objUsuario.UsuarioId = UsuarioId;
                    objUsuario.Codigo = txtUsuario.Text;
                    objUsuario.Password = txtContrasenia.Text;
                    objUsuario.RolId = Convert.ToInt32(cbRol.SelectedValue.ToString());
                    objUsuarioBC.EditarUsuario(objUsuario);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MiDelegado();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
    }
}
