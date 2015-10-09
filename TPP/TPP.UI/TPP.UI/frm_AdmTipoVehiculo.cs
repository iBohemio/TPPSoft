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
        }
        public void dgvTipoVehiculoConfigurar()
        {
            dgvTipoVehiculo.Columns["TipoVehiculoId"].Visible = false;
            dgvTipoVehiculo.Columns["Codigo"].HeaderText = "Código";
            dgvTipoVehiculo.Columns["Nombre"].HeaderText = "Nombre";
            dgvTipoVehiculo.Columns["PesoMaximo"].HeaderText = "Peso Máximo";
            dgvTipoVehiculo.Columns["Estado"].Visible = false;

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
