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
    public partial class frm_TipoContenedor : Form
    {
        public frm_TipoContenedor()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int TipoContenedorId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_TipoContenedor_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Tipo de Contenedor";
                if (Modo == TypeMode.Registrar)
                {
                    lblTipoContenedor.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblTipoContenedor.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar la " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    TipoContenedorBC objTipoContenedorBC = new TipoContenedorBC();
                    TipoContenedor objTipoContenedor = objTipoContenedorBC.BuscarTipoContenedor(TipoContenedorId);
                    txtDescripcion.Text = objTipoContenedor.Descripcion;
                }
                txtDescripcion.Focus();
            }
            catch (Exception ex)
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
                TipoContenedorBC objTipoContenedorBC = new TipoContenedorBC();
                TipoContenedor objTipoContenedor = new TipoContenedor();
                objTipoContenedor.Descripcion = txtDescripcion.Text.ToUpper();
                objTipoContenedor.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objTipoContenedorBC.RegistrarTipoContenedor(objTipoContenedor);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objTipoContenedor.TipoContenedorId = TipoContenedorId;
                    objTipoContenedorBC.EditarTipoContenedor(objTipoContenedor);
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
