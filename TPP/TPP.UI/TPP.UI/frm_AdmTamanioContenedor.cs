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
    public partial class frm_AdmTamanioContenedor : Form
    {
        public frm_AdmTamanioContenedor()
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
        public void dgvTamanioContenedorConfigurar()
        {
            dgvTamanioContenedor.Columns["TamanioContenedorId"].Visible = false;
            dgvTamanioContenedor.Columns["Estado"].Visible = false;
            dgvTamanioContenedor.Columns["Contenedor"].Visible = false;
            dgvTamanioContenedor.Columns["Descripcion"].HeaderText = "Código";
        }
        private void RefrescarGrilla()
        {
            TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
            dgvTamanioContenedor.DataSource = objTamanioContenedorBC.ListarTamanioContenedor();
            dgvTamanioContenedorConfigurar();
        }
        private void frm_AdmTamanioContenedor_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvTamanioContenedor);
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
                frm_TamanioContenedor frm = new frm_TamanioContenedor();
                frm.Modo = frm_TamanioContenedor.TypeMode.Registrar;
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
                frm_TamanioContenedor frm = new frm_TamanioContenedor();
                frm.Modo = frm_TamanioContenedor.TypeMode.Editar;
                frm.TamanioContenedorId = Convert.ToInt32(dgvTamanioContenedor.SelectedRows[0].Cells["TamanioContenedorId"].Value);
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
                if (dgvTamanioContenedor.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el Tamaño de Contenedor: " + dgvTamanioContenedor.SelectedRows[0].Cells["Descripcion"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
                    objTamanioContenedorBC.EliminarTamanioContenedor(Convert.ToInt32(dgvTamanioContenedor.SelectedRows[0].Cells["TamanioContenedorId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Tamaño de Contenedor.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
                dgvTamanioContenedor.DataSource = objTamanioContenedorBC.Filtro(txtFiltro.Text);

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
