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
    public partial class frm_AdmEmbalaje : Form
    {
        public frm_AdmEmbalaje()
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
        public void dgvEmbalajeConfigurar()
        {
            dgvEmbalaje.Columns["EmbalajeId"].Visible = false;
            dgvEmbalaje.Columns["Estado"].Visible = false;
            dgvEmbalaje.Columns["Autorizacion"].Visible = false;
            dgvEmbalaje.Columns["Codigo"].HeaderText = "Código";
            dgvEmbalaje.Columns["Descripcion"].HeaderText = "Descripción";
        }
        private void RefrescarGrilla()
        {
            EmbalajeBC objEmbalajeBC = new EmbalajeBC();
            dgvEmbalaje.DataSource = objEmbalajeBC.ListarEmbalaje();
            dgvEmbalajeConfigurar();
        }
        private void frm_AdmEmbalaje_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvEmbalaje);
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
                frm_Embalaje frm = new frm_Embalaje();
                frm.Modo = frm_Embalaje.TypeMode.Registrar;
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
                frm_Embalaje frm = new frm_Embalaje();
                frm.Modo = frm_Embalaje.TypeMode.Editar;
                frm.EmbalajeId = Convert.ToInt32(dgvEmbalaje.SelectedRows[0].Cells["EmbalajeId"].Value);
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
                if (dgvEmbalaje.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el Embalaje: " + dgvEmbalaje.SelectedRows[0].Cells["Codigo"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    EmbalajeBC objEmbalajeBC = new EmbalajeBC();
                    objEmbalajeBC.EliminarEmbalaje(Convert.ToInt32(dgvEmbalaje.SelectedRows[0].Cells["EmbalajeId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Embalaje.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                EmbalajeBC objEmbalajeBC= new EmbalajeBC();
                dgvEmbalaje.DataSource = objEmbalajeBC.Filtro(txtFiltro.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Disculpe, el sistema se encuetra fuera de servicio",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
