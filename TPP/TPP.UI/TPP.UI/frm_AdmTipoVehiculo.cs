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
    public partial class frm_AdmTipoVehiculo : Form
    {
        public frm_AdmTipoVehiculo()
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
        public void dgvTipoVehiculoConfigurar()
        {
            dgvTipoVehiculo.Columns["TipoVehiculoId"].Visible = false;
            dgvTipoVehiculo.Columns["Estado"].Visible = false;
            dgvTipoVehiculo.Columns["Vehiculo"].Visible = false;
            dgvTipoVehiculo.Columns["Codigo"].HeaderText = "Código";
            dgvTipoVehiculo.Columns["Nombre"].HeaderText = "Nombre";
            dgvTipoVehiculo.Columns["PesoMaximo"].HeaderText = "Peso Máximo";
          

        }
        private void RefrescarGrilla()
        {
            TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
            dgvTipoVehiculo.DataSource = objTipoVehiculoBC.ListarTipoVehiculo();
            dgvTipoVehiculoConfigurar();
        }

        private void frm_AdmTipoVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvTipoVehiculo);
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
                frm_TipoVehiculo frm = new frm_TipoVehiculo();
                frm.Modo = frm_TipoVehiculo.TypeMode.Registrar;
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
                frm_TipoVehiculo frm = new frm_TipoVehiculo();
                frm.Modo = frm_TipoVehiculo.TypeMode.Editar;
                frm.TipoVehiculoId = Convert.ToInt32(dgvTipoVehiculo.SelectedRows[0].Cells["TipoVehiculoId"].Value);
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
                if (dgvTipoVehiculo.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el Tipo de Vehiculo: " + dgvTipoVehiculo.SelectedRows[0].Cells["Nombre"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                    objTipoVehiculoBC.EliminarTipoVehiculo(Convert.ToInt32(dgvTipoVehiculo.SelectedRows[0].Cells["TipoVehiculoId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Tipo de Vehiculo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                dgvTipoVehiculo.DataSource = objTipoVehiculoBC.Filtro(txtFiltro.Text);

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
