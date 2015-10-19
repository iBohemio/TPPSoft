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
    public partial class frm_GuiaRemision : Form
    {
        public frm_GuiaRemision()
        {
            InitializeComponent();
        }
       
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int GuiaRemisionId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_GuiaRemision_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Guía de Remisión";
                if (Modo == TypeMode.Registrar)
                {
                    lblGuia.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar la " + Entidad + "?";
                    MensajeRespuesta = "Se registró la " + Entidad + " satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblGuia.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar la " + Entidad + "?";
                    MensajeRespuesta = "Se editó la " + Entidad + " satisfactoriamente.";
                    GuiaRemisionBC objGuiaRemisionBC = new GuiaRemisionBC();
                    GuiaRemision objGuiaRemision = objGuiaRemisionBC.BuscarGuiaRemision(GuiaRemisionId);
                    txtDocumento.Text = objGuiaRemision.Documento;
                    nudBultos.Value = objGuiaRemision.Bultos;
                }
                txtDocumento.Focus();
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

                GuiaRemision objGuiaRemision = new GuiaRemision();
                GuiaRemisionBC objGuiaRemisionBC = new GuiaRemisionBC();
                objGuiaRemision.Documento = txtDocumento.Text;
                objGuiaRemision.Bultos = Convert.ToInt32(nudBultos.Value.ToString());
                objGuiaRemision.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objGuiaRemisionBC.RegistrarGuiaRemision(objGuiaRemision);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objGuiaRemision.GuiaRemisionId = GuiaRemisionId;
                    objGuiaRemisionBC.EditarGuiaRemision(objGuiaRemision);
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
