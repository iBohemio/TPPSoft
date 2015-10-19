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
    public partial class frm_AdmUsuario : Form
    {
        public frm_AdmUsuario()
        {
            InitializeComponent();
        }
        public void ConfigurarControles(DataGridView dgv)
        {
            dgv.AllowDrop = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void dgvUsuarioConfigurar()
        {

            dgvUsuario.Columns["UsuarioId"].DisplayIndex = 0;
            dgvUsuario.Columns["Nombres"].DisplayIndex = 1;
            dgvUsuario.Columns["Rol"].DisplayIndex = 2;
            dgvUsuario.Columns["RolId"].Visible = false;
            dgvUsuario.Columns["UsuarioId"].HeaderText = "Código";
            dgvUsuario.Columns["Nombres"].HeaderText = "Usuario";
            dgvUsuario.Columns["Rol"].HeaderText = "Rol";
        }
        private void RefrescarGrilla()
        {
            UsuarioBC objUsuarioBC = new UsuarioBC();
            dgvUsuario.DataSource = objUsuarioBC.UsuarioListarCompleto();
            dgvUsuarioConfigurar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_AdmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvUsuario);
                RefrescarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                               this.Text,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Usuario frm = new frm_Usuario();
                frm.Modo=frm_Usuario.TypeMode.Registrar;
                frm.MiDelegado += RefrescarGrilla;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Usuario frm = new frm_Usuario();
                frm.Modo = frm_Usuario.TypeMode.Editar;
                frm.UsuarioId = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["UsuarioId"].Value);
                frm.MiDelegado += RefrescarGrilla;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvUsuario.SelectedRows.Count!=0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar al usuario: "+dgvUsuario.SelectedRows[0].Cells["Nombres"].Value.ToString()+"?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    UsuarioBC objUsuarioBC = new UsuarioBC();
                    objUsuarioBC.EliminarUsuario(Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["UsuarioId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 
            }
            catch (Exception)
            {

                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                 this.Text,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UsuarioBC objUsuarioBC = new UsuarioBC();
                dgvUsuario.DataSource = objUsuarioBC.Filtro(txtFiltro.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuetra fuera de servicio",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
