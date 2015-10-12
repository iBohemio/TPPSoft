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
    public partial class frm_Embalaje : Form
    {
        public frm_Embalaje()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int EmbalajeId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_Embalaje_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Embalaje";
                if (Modo == TypeMode.Registrar)
                {
                    lblEmbalaje.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblEmbalaje.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    EmbalajeBC objEmbalajeBC = new EmbalajeBC();
                    Embalaje objEmbalaje = objEmbalajeBC.BuscarEmbalaje(EmbalajeId);
                    txtCodigo.Text = objEmbalaje.Codigo;
                    txtDescripcion.Text = objEmbalaje.Descripcion;
                }
                txtCodigo.Focus();
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
                EmbalajeBC objEmbalajeBC = new EmbalajeBC();
                Embalaje objEmbalaje = new Embalaje();
                objEmbalaje.Codigo = txtCodigo.Text.ToUpper();
                objEmbalaje.Descripcion = txtDescripcion.Text.ToUpper();
                objEmbalaje.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objEmbalajeBC.RegistrarEmbalaje(objEmbalaje);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objEmbalaje.EmbalajeId = EmbalajeId;
                    objEmbalajeBC.EditarEmbalaje(objEmbalaje);
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
