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
    public partial class frm_AdmTipoContenedor : Form
    {
        public frm_AdmTipoContenedor()
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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void dgvTipoContenedorConfigurar()
        {
            dgvTipoContenedor.Columns["TipoContenedorId"].Visible = false;
            dgvTipoContenedor.Columns["Estado"].Visible = false;
            dgvTipoContenedor.Columns["Contenedor"].Visible = false;
            dgvTipoContenedor.Columns["Pesaje"].Visible = false;
            dgvTipoContenedor.Columns["Descripcion"].HeaderText = "Descripción";
        }
        private void RefrescarGrilla()
        {
            TipoContenedorBC objTipoContenedorBC = new TipoContenedorBC();
            dgvTipoContenedor.DataSource = objTipoContenedorBC.ListarTipoContenedor();
            dgvTipoContenedorConfigurar();
        }
        private void frm_AdmTipoContenedor_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvTipoContenedor);
                RefrescarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                     this.Text,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
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
                frm_TipoContenedor frm = new frm_TipoContenedor();
                frm.Modo = frm_TipoContenedor.TypeMode.Registrar;
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
                frm_TipoContenedor frm = new frm_TipoContenedor();
                frm.Modo = frm_TipoContenedor.TypeMode.Editar;
                frm.TipoContenedorId = Convert.ToInt32(dgvTipoContenedor.SelectedRows[0].Cells["TipoContenedorId"].Value);
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
                if (dgvTipoContenedor.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el Tipo de Contenedor: " + dgvTipoContenedor.SelectedRows[0].Cells["Descripcion"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    TipoContenedorBC objTipoContenedorBC = new TipoContenedorBC();
                    objTipoContenedorBC.EliminarTipoContenedor(Convert.ToInt32(dgvTipoContenedor.SelectedRows[0].Cells["TipoContenedorId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Tipo de Contenedor.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
