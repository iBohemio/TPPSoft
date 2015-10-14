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
    public partial class frm_AdmTurno : Form
    {
        public frm_AdmTurno()
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
            dgvTurno.Columns["TurnoId"].Visible = false;
            dgvTurno.Columns["Estado"].Visible = false;
            dgvTurno.Columns["Reporte"].Visible = false;
            //dgvTurno.Columns["ApellidoPaterno"].HeaderText = "Ap. Paterno";
            //dgvTurno.Columns["ApellidoMaterno"].HeaderText = "Ap. Materno";
        }
        private void RefrescarGrilla()
        {
            TurnoBC objTurnoBC = new TurnoBC();
            dgvTurno.DataSource = objTurnoBC.ListarTurno();
            dgvConductorConfigurar();
        }
        private void frm_AdmTurno_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvTurno);
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
                frm_Turno frm = new frm_Turno();
                frm.Modo = frm_Turno.TypeMode.Registrar;
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
                frm_Turno frm = new frm_Turno();
                frm.Modo = frm_Turno.TypeMode.Editar;
                frm.TurnoId = Convert.ToInt32(dgvTurno.SelectedRows[0].Cells["TurnoId"].Value);
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
                if (dgvTurno.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el Turno: " + dgvTurno.SelectedRows[0].Cells["Nombre"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    TurnoBC objTurnoBC = new TurnoBC();
                    objTurnoBC.EliminarTurno(Convert.ToInt32(dgvTurno.SelectedRows[0].Cells["TurnoId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Turno.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
