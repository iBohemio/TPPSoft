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
    public partial class frm_AdmOperacion : Form
    {
        public frm_AdmOperacion()
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
        public void dgvOperacionConfigurar()
        {
            dgvOperacion.Columns["OperacionId"].Visible = false;
            dgvOperacion.Columns["Estado"].Visible = false;
            dgvOperacion.Columns["Autorizacion"].Visible = false;
            dgvOperacion.Columns["Codigo"].HeaderText = "Código";
            dgvOperacion.Columns["Descripcion"].HeaderText = "Descripción";
        }
        private void RefrescarGrilla()
        {
            OperacionBC objOperacionBC = new OperacionBC();
            dgvOperacion.DataSource = objOperacionBC.ListarOperacion();
            dgvOperacionConfigurar();
        }
        private void frm_AdmOperacion_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvOperacion);
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
                frm_Operacion frm = new frm_Operacion();
                frm.Modo = frm_Operacion.TypeMode.Registrar;
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
                frm_Operacion frm = new frm_Operacion();
                frm.Modo = frm_Operacion.TypeMode.Editar;
                frm.OperacionId = Convert.ToInt32(dgvOperacion.SelectedRows[0].Cells["OperacionId"].Value);
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
                if (dgvOperacion.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar la operación: " + dgvOperacion.SelectedRows[0].Cells["Codigo"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    OperacionBC objOperacionBC = new OperacionBC();
                    objOperacionBC.EliminarOperacion(Convert.ToInt32(dgvOperacion.SelectedRows[0].Cells["OperacionId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente la Operación.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
