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
    public partial class frm_AdmConductor : Form
    {
        public frm_AdmConductor()
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
        public void dgvConductorConfigurar()
        {
            dgvConductor.Columns["ConductorId"].Visible = false;
            dgvConductor.Columns["Estado"].Visible = false;
            dgvConductor.Columns["Pesaje"].Visible = false;
            dgvConductor.Columns["Vehiculo"].Visible = false;
            dgvConductor.Columns["ApellidoPaterno"].HeaderText = "Ap. Paterno";
            dgvConductor.Columns["ApellidoMaterno"].HeaderText = "Ap. Materno";
        }
        private void RefrescarGrilla()
        {
            ConductorBC objConductorBC = new ConductorBC();
            dgvConductor.DataSource = objConductorBC.ListarConductor();
            dgvConductorConfigurar();
        }

        private void frm_AdmConductor_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvConductor);
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
                frm_Conductor frm = new frm_Conductor();
                frm.Modo = frm_Conductor.TypeMode.Registrar;
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
                frm_Conductor frm = new frm_Conductor();
                frm.Modo = frm_Conductor.TypeMode.Editar;
                frm.ConductorId = Convert.ToInt32(dgvConductor.SelectedRows[0].Cells["ConductorId"].Value);
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
                if (dgvConductor.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el conductor: " + dgvConductor.SelectedRows[0].Cells["Nombres"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    ConductorBC objConductorBC = new ConductorBC();
                    objConductorBC.EliminarConductor(Convert.ToInt32(dgvConductor.SelectedRows[0].Cells["ConductorId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Conductor.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
