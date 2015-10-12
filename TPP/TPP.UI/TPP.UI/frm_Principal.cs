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
    public partial class frm_Principal : Form
    {
        
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void ConfigurarControles()
        {
            tsCerrarSesion.Visible = false;
            tsAdministrar.Visible = false;
            tsEntrada.Visible = false;
            tsSalida.Visible = false;
            tsReimpresion.Visible = false;
            tsEntidad.Visible = false;
            sslbl_Rol.Text = ".";
            sslbl_Usuario.Text = "Bienvenido:";
        }

        private void RecibirDatos(Usuario UsuarioObj)
        {

            sslbl_Usuario.Text = "Bienvenido: " + UsuarioObj.Codigo.ToString();
            sslbl_Rol.Text = "Rol: " + UsuarioObj.Rol.Descripcion.ToString();
            tsAdministrar.Visible = true;
            tsEntrada.Visible = true;
            tsSalida.Visible = true;
            tsReimpresion.Visible = true;
            tsCerrarSesion.Visible = true;
            tsEntidad.Visible =UsuarioObj.Rol.Descripcion.ToUpper()=="ADMINISTRADOR"? true:false;
        }
        private void frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles();
                frm_Login frm = new frm_Login();
                frm.MiDelegado += RecibirDatos;
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                   this.Text,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
          
           
        }

        private void tsEntidad_Click(object sender, EventArgs e)
        {

        }

       private void miVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmVehiculo);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmVehiculo();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                    this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
          
        }

        private void miConductor_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmConductor);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmConductor();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                   this.Text,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
           
        }

        private void miAutorizacion_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmAutorizacion);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmAutorizacion();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                    this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            
        }

        private void miEmbalaje_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmEmbalaje);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmEmbalaje();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                    this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
           
        }

        private void miOperacion_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmOperacion);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmOperacion();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                                  this.Text,
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
            }
            
        }

        private void miTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmTurno);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmTurno();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                    this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
           
        }

        private void miNave_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmNave);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmNave();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                    this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            
        }

        private void miUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmUsuario);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmUsuario();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                   this.Text,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            
        }

        private void miTipoContenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmTipoContenedor);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmTipoContenedor();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                       this.Text,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
            
        }

        private void miTamanioContenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmTamanioContenedor);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmTamanioContenedor();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                       this.Text,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
            
        }

        private void miContenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmContenedor);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmContenedor();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                      this.Text,
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
            }
            
        }

        private void miRegistrarPesaje_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_RegistrarPesaje);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_RegistrarPesaje();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                      this.Text,
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
            }
            
        }

        private void miControlarPesaje_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_ControlarPesaje);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_ControlarPesaje();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                     this.Text,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            
        }

        private void miTipoVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_AdmTipoVehiculo);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm = new frm_AdmTipoVehiculo();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                      this.Text,
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
            }
            
        }

        private void tsCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles();
                frm_Login frm = new frm_Login();
                frm.MiDelegado += RecibirDatos;
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                    this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            
        }
    }
}
