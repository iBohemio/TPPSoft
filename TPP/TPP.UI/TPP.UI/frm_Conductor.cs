using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPP.BL.BC;
using TPP.DL.DataModel;
namespace TPP.UI
{
    public partial class frm_Conductor : Form
    {
        public frm_Conductor()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int ConductorId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_Conductor_Load(object sender, EventArgs e)
        {
             try
            {
                Entidad = "Conductor";
                if (Modo == TypeMode.Registrar)
                {
                    lblConductor.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblConductor.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    ConductorBC objConductorBC = new ConductorBC();
                    Conductor objConductor = objConductorBC.BuscarConductor(ConductorId);
                    txtBrevete.Text = objConductor.NroBrevete;
                    txtNombres.Text = objConductor.Nombres;
                    txtAPaterno.Text = objConductor.ApellidoPaterno;
                    txtAMaterno.Text=objConductor.ApellidoMaterno;
                }
                txtBrevete.Focus();
            }
             catch (Exception ex)
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
                if (MessageBox.Show(MensajePregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                ConductorBC objConductorBC = new ConductorBC();
                Conductor objConductor = new Conductor();
                objConductor.NroBrevete = txtBrevete.Text.ToUpper();
                objConductor.Nombres = txtNombres.Text.ToUpper();
                objConductor.ApellidoPaterno = txtAPaterno.Text.ToUpper();
                objConductor.ApellidoMaterno = txtAMaterno.Text.ToUpper();
                objConductor.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objConductorBC.RegistrarConductor(objConductor);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objConductor.ConductorId = ConductorId;
                    objConductorBC.EditarConductor(objConductor);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MiDelegado();
                this.Dispose();
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
