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
    public partial class frm_AdmVehiculo : Form
    {
        public frm_AdmVehiculo()
        {
            InitializeComponent();
        }
        public enum TypeMode { Buscar, Normal }
        public TypeMode Modo { get; set; }
        public delegate void EnviarDatos(Vehiculo ObjVehiculo);
        public EnviarDatos MiDelegado;
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
            dgvVehiculo.Columns["VehiculoId"].Visible = false;
            dgvVehiculo.Columns["TipoVehiculoId"].Visible = false;
            dgvVehiculo.Columns["Estado"].Visible = false;
            dgvVehiculo.Columns["TipoVehiculo"].HeaderText = "Tipo de Vehiculo";
        }
        private void RefrescarGrilla()
        {
            VehiculoBC objVehiculoBC = new VehiculoBC();
            dgvVehiculo.DataSource = objVehiculoBC.ListarVehiculo();
            dgvTipoVehiculoConfigurar();
        }

        private void frm_AdmVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeMode.Normal)
                {
                    lblAdmVehiculo.Text = "Administrar Vehiculo";
                }
                if (Modo == TypeMode.Buscar)
                {
                    lblAdmVehiculo.Text = "Buscar Vehiculo";
                }
                ConfigurarControles(dgvVehiculo);
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
                frm_Vehiculo frm = new frm_Vehiculo();
                frm.Modo = frm_Vehiculo.TypeMode.Registrar;
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
                frm.TipoVehiculoId = Convert.ToInt32(dgvVehiculo.SelectedRows[0].Cells["VehiculoId"].Value);
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
                if (dgvVehiculo.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el vehiculo de placa: " + dgvVehiculo.SelectedRows[0].Cells["Placa"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                    objTipoVehiculoBC.EliminarTipoVehiculo(Convert.ToInt32(dgvVehiculo.SelectedRows[0].Cells["VehiculoId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Vehiculo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                VehiculoBC objVehiculoBC = new VehiculoBC();
                dgvVehiculo.DataSource = objVehiculoBC.Filtro(txtFiltro.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Disculpe, el sistema se encuetra fuera de servicio",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvVehiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Modo == TypeMode.Buscar)
            {
                Vehiculo objVehiculo = new Vehiculo();
                objVehiculo.VehiculoId = Convert.ToInt32(dgvVehiculo.SelectedRows[0].Cells["VehiculoId"].Value.ToString());
                objVehiculo.Placa =  dgvVehiculo.SelectedRows[0].Cells["Placa"].Value.ToString();
                objVehiculo.Carrete = dgvVehiculo.SelectedRows[0].Cells["Carrete"].Value.ToString();
                objVehiculo.TipoVehiculoId = Convert.ToInt32(dgvVehiculo.SelectedRows[0].Cells["TipoVehiculoId"].Value.ToString());
                MiDelegado(objVehiculo);
                this.Dispose();
            }
        }
    }
}
