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

        private void frm_TipoVehiculo_Load(object sender, EventArgs e)
        {
            try
            {

                
            
                if (Modo == TypeMode.Registrar)
                {
                    lblTipoVehiculo.Text = "Registrar Tipo de Vehiculo";
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el Tipo de Vehiculo?";
                    MensajeRespuesta = "Se registró el Tipo de Vehiculo satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblTipoVehiculo.Text = "Editar Tipo de Vehiculo";
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el Tipo de Vehiculo?";
                    MensajeRespuesta = "Se editó el Tipo de Vehiculo satisfactoriamente.";
                    TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                    TipoVehiculo objTipoVehiculo = objTipoVehiculoBC.BuscarTipoVehiculo(TipoVehiculoId);
                    //falta
                    //txtCodigo.Text = objTipoVehiculo.;
                    //txtNombre.Text = objTipoVehiculo.Password;
                    //nudPesoMaximo.Value = objUsuario.RolId;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                   this.Text,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
    }
}
