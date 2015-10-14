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
    public partial class frm_AdmNave : Form
    {
        public frm_AdmNave()
        {
            InitializeComponent();
        }
        public enum TypeMode { Buscar, Normal }
        public TypeMode Modo { get; set; }
        public delegate void EnviarDatos(int NaveId, string nombre);
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
            dgvNave.Columns["NaveId"].Visible = false;
            dgvNave.Columns["Estado"].Visible = false;
            dgvNave.Columns["Autorizacion"].Visible = false;
            dgvNave.Columns["Pesaje"].Visible = false;
            dgvNave.Columns["Contenedor"].Visible = false;
        }
        private void RefrescarGrilla()
        {
            NaveBC objNaveBC = new NaveBC();
            dgvNave.DataSource = objNaveBC.ListarNave();
            dgvTipoVehiculoConfigurar();
        }
        private void frm_AdmNave_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeMode.Normal)
                {
                    lblAdmNave.Text = "Administrar Nave";
                }
                else if (Modo == TypeMode.Buscar)
                {
                    lblAdmNave.Text = "Buscar Nave";
                }
                ConfigurarControles(dgvNave);
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Nave frm = new frm_Nave();
                frm.Modo = frm_Nave.TypeMode.Registrar;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Nave frm = new frm_Nave();
                frm.Modo = frm_Nave.TypeMode.Editar;
                frm.NaveId = Convert.ToInt32(dgvNave.SelectedRows[0].Cells["NaveId"].Value);
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
                if (dgvNave.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar la nave: " + dgvNave.SelectedRows[0].Cells["Nombre"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    NaveBC objNaveBC = new NaveBC();
                    objNaveBC.EliminarNave(Convert.ToInt32(dgvNave.SelectedRows[0].Cells["NaveId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente la nave.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvNave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Modo == TypeMode.Buscar)
            {
                MiDelegado(Convert.ToInt32(dgvNave.SelectedRows[0].Cells["NaveId"].Value.ToString()), dgvNave.SelectedRows[0].Cells["Nombre"].Value.ToString());
                this.Dispose();
            }
        }
    }
}
