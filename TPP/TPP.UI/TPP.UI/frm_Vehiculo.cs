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
    public partial class frm_Vehiculo : Form
    {
        public frm_Vehiculo()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int VehiculoId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_Vehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Vehiculo";
                TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                cbTipoVehiculo.DataSource = objTipoVehiculoBC.ListarTipoVehiculo();
                cbTipoVehiculo.DisplayMember = "Nombre";
                cbTipoVehiculo.ValueMember = "TipoVehiculoId";
                if (Modo == TypeMode.Registrar)
                {
                    lblVehiculo.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " +Entidad+"?";
                    MensajeRespuesta = "Se registró el "+Entidad+" satisfactoriamente.";
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblVehiculo.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el " +Entidad+"?";
                    MensajeRespuesta = "Se editó el "+Entidad+" satisfactoriamente.";
                    VehiculoBC objVehiculoBC = new VehiculoBC();
                    Vehiculo objVehiculo = objVehiculoBC.BuscarVehiculo(VehiculoId);
                    txtCarrete.Text = objVehiculo.Carrete;
                    txtPlaca.Text = objVehiculo.Placa;
                    cbTipoVehiculo.SelectedValue = objVehiculo.TipoVehiculoId;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarComponentes()) return;
                if (MessageBox.Show(MensajePregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                VehiculoBC objVehiculoBC = new VehiculoBC();
                Vehiculo objVehiculo = new Vehiculo();
                objVehiculo.Placa = txtPlaca.Text.ToUpper();
                objVehiculo.Carrete = txtCarrete.Text.ToUpper();
                objVehiculo.TipoVehiculoId = Convert.ToInt32(cbTipoVehiculo.SelectedValue.ToString());
                objVehiculo.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objVehiculoBC.RegistrarVehiculo(objVehiculo);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Modo == TypeMode.Editar)
                {
                    objVehiculo.VehiculoId = VehiculoId;
                    objVehiculoBC.EditarVehiculo(objVehiculo);
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
        private bool ValidarComponentes()
        {
            bool validar = true;

            if (txtPlaca.Text.Length != 7 || txtPlaca.Text.Contains(" "))
            {
                epTxt.Icon = Properties.Resources.FAIL;
                epTxt.SetError(txtPlaca, "Dato Invalido");
                validar = false;
            }
            else
            {
                epTxt.Clear();


                if (txtCarrete.Text.Length != 7 || txtCarrete.Text.Contains(" "))
                {
                    epTxt.Icon = Properties.Resources.FAIL;
                    epTxt.SetError(txtCarrete, "Dato Invalido");
                    validar = false;
                }
                else
                {
                    epTxt.Clear();
                }
            }
            return validar;
        }
    }
}
