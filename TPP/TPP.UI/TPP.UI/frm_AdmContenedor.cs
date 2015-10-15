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
    public partial class frm_AdmContenedor : Form
    {
        public frm_AdmContenedor()
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
        public void dgvContenedorConfigurar()
        {
            dgvContenedor.Columns["ContenedorId"].Visible = false;
            dgvContenedor.Columns["Estado"].Visible = false;
            //dgvContenedor.Columns["Contenedor"].Visible = false;
            //dgvContenedor.Columns["Pesaje"].Visible = false;
            //dgvContenedor.Columns["Descripcion"].HeaderText = "Descripción";
        }
        private void RefrescarGrilla()
        {
            ContenedorBC objContenedorBC = new ContenedorBC();
            dgvContenedor.DataSource = objContenedorBC.ContenedorListarCompleto();
            dgvContenedorConfigurar();
        }
        private void frm_AdmContenedor_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvContenedor);
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
                frm_Contenedor frm = new frm_Contenedor();
                frm.Modo = frm_Contenedor.TypeMode.Registrar;
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
                frm_Contenedor frm = new frm_Contenedor();
                frm.Modo = frm_Contenedor.TypeMode.Editar;
                frm.ContenedorId = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["ContenedorId"].Value);
                frm.NaveId = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["NaveId"].Value);
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
                if (dgvContenedor.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar el Contenedor: " + dgvContenedor.SelectedRows[0].Cells["Codigo"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    ContenedorBC objContenedorBC = new ContenedorBC();
                    objContenedorBC.EliminarContenedor(Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["ContenedorId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente el Contenedor.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
