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
    public partial class frm_AdmAutorizacion : Form
    {
        public frm_AdmAutorizacion()
        {
            InitializeComponent();
        }
        public int UsuarioId { get; set; }
        
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
        public void dgvAutorizacionConfigurar()
        {
            dgvAutorizacion.Columns["NaveId"].Visible = false;
            dgvAutorizacion.Columns["UsuarioId"].Visible = false;
            dgvAutorizacion.Columns["EmbalajeId"].Visible = false;
            dgvAutorizacion.Columns["OperacionId"].Visible = false;
            dgvAutorizacion.Columns["AutorizacionId"].Visible = false;
            dgvAutorizacion.Columns["Codigo"].DisplayIndex = 0;
            dgvAutorizacion.Columns["Nave"].DisplayIndex = 1;
            dgvAutorizacion.Columns["Operacion"].DisplayIndex = 2;
            dgvAutorizacion.Columns["Embalaje"].DisplayIndex = 3;
            dgvAutorizacion.Columns["NroBultos"].DisplayIndex = 4;
            dgvAutorizacion.Columns["Peso"].DisplayIndex = 5;
            dgvAutorizacion.Columns["Producto"].DisplayIndex = 6;
            dgvAutorizacion.Columns["Estado"].DisplayIndex = 7;
            dgvAutorizacion.Columns["Codigo"].HeaderText = "Código";
            dgvAutorizacion.Columns["Operacion"].HeaderText = "Operación";
            dgvAutorizacion.Columns["NroBultos"].HeaderText = "Nro. Bultos";
            dgvAutorizacion.Columns["Peso"].HeaderText = "Peso (Kg.)";
            dgvAutorizacion.Columns["Peso"].Width = 100;
            dgvAutorizacion.Columns["Fecha"].Width = 150;
            //dgvAutorizacion.Columns["Contenedor"].Visible = false;
        }
        private void RefrescarGrilla()
        {
            AutorizacionBC objAutorizacionBC = new AutorizacionBC();
            dgvAutorizacion.DataSource = objAutorizacionBC.AutorizacionListarCompleto();
            dgvAutorizacionConfigurar();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Autorizacion frm = new frm_Autorizacion();
                frm.Modo = frm_Autorizacion.TypeMode.Registrar;
                frm.UsuarioId = UsuarioId;
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
                frm_Autorizacion frm = new frm_Autorizacion();
                frm.Modo = frm_Autorizacion.TypeMode.Editar;
                frm.UsuarioId = UsuarioId;
                frm.NaveId = Convert.ToInt32(dgvAutorizacion.SelectedRows[0].Cells["NaveId"].Value);
                frm.EmbalajeId = Convert.ToInt32(dgvAutorizacion.SelectedRows[0].Cells["EmbalajeId"].Value);
                frm.OperacionId = Convert.ToInt32(dgvAutorizacion.SelectedRows[0].Cells["OperacionId"].Value);
                frm.AutorizacionId = Convert.ToInt32(dgvAutorizacion.SelectedRows[0].Cells["AutorizacionId"].Value);
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
                if (dgvAutorizacion.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar la autorización: " + dgvAutorizacion.SelectedRows[0].Cells["Codigo"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    AutorizacionBC objAutorizacionBC = new AutorizacionBC();
                    objAutorizacionBC.EliminarAutorizacion(Convert.ToInt32(dgvAutorizacion.SelectedRows[0].Cells["AutorizacionId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente la autorización.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_AdmAutorizacion_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvAutorizacion);
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
    }
}
