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
    public partial class frm_TipoVehiculo : Form
    {
        public frm_TipoVehiculo()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int TipoVehiculoId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_TipoVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Tipo de Vehiculo";
                if (Modo == TypeMode.Registrar)
                {
                    lblTipoVehiculo.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblTipoVehiculo.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                    TipoVehiculo objTipoVehiculo = objTipoVehiculoBC.BuscarTipoVehiculo(TipoVehiculoId);
                    txtCodigo.Text = objTipoVehiculo.Codigo;
                    txtNombre.Text = objTipoVehiculo.Nombre;
                    nudPesoMaximo.Value = objTipoVehiculo.PesoMaximo;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MensajePregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                TipoVehiculo objTipoVehiculo = new TipoVehiculo();
                objTipoVehiculo.Codigo = txtCodigo.Text.ToUpper();
                objTipoVehiculo.Nombre = txtNombre.Text.ToUpper();
                objTipoVehiculo.PesoMaximo = nudPesoMaximo.Value;
                objTipoVehiculo.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objTipoVehiculoBC.RegistrarTipoVehiculo(objTipoVehiculo);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (Modo == TypeMode.Editar)
                {
                    objTipoVehiculo.TipoVehiculoId = TipoVehiculoId;
                    objTipoVehiculoBC.EditarTipoVehiculo(objTipoVehiculo);
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
