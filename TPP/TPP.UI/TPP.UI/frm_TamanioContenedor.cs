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
    public partial class frm_TamanioContenedor : Form
    {
        public frm_TamanioContenedor()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int TamanioContenedorId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_TamanioContenedor_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Tamaño de Contenedor";
                if (Modo == TypeMode.Registrar)
                {
                    lblTamanioContenedor.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblTamanioContenedor.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar la " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
                    TamanioContenedor objTamanioContenedor = objTamanioContenedorBC.BuscarTamanioContenedor(TamanioContenedorId);
                    txtCodigo.Text = objTamanioContenedor.Descripcion;
                }
                txtCodigo.Focus();
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
                if (MessageBox.Show(MensajePregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
                TamanioContenedor objTamanioContenedor = new TamanioContenedor();
                objTamanioContenedor.Descripcion = txtCodigo.Text.ToUpper();
                objTamanioContenedor.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objTamanioContenedorBC.RegistrarTamanioContenedor(objTamanioContenedor);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objTamanioContenedor.TamanioContenedorId = TamanioContenedorId;
                    objTamanioContenedorBC.EditarTamanioContenedor(objTamanioContenedor);
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
    }
}
