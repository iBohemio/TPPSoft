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
    public partial class frm_Contenedor : Form
    {
        public frm_Contenedor()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int ContenedorId { get; set; }
        public int NaveId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void RecibirDatosNave(int naveId, string nombre)
        {
            NaveId = naveId;
            txtNave.Text = nombre;
        }
        private void frm_Contenedor_Load(object sender, EventArgs e)
        {
            try
            {
                TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
                TipoContenedorBC objTipoContenedorBC = new TipoContenedorBC();
                cbTamanioContenedor.DataSource = objTamanioContenedorBC.ListarTamanioContenedor();
                cbTamanioContenedor.DisplayMember = "Descripcion";
                cbTamanioContenedor.ValueMember = "TamanioContenedorId";
                cbTipoContenedor.DataSource = objTipoContenedorBC.ListarTipoContenedor();
                cbTipoContenedor.DisplayMember = "Descripcion";
                cbTipoContenedor.ValueMember = "TipoContenedorId";
                Entidad = "Contenedor";
                if (Modo == TypeMode.Registrar)
                {
                    lblContenedor.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                    cbEstado.SelectedIndex = cbTipoMovimiento.SelectedIndex= 0;
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblContenedor.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar la " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    ContenedorBC objContenedorBC = new ContenedorBC();
                    Contenedor objContenedor = objContenedorBC.BuscarContenedor(ContenedorId);
                    txtCodigo.Text = objContenedor.Codigo;
                    txtEmbarcadero.Text = objContenedor.Embarcadero;
                    txtPesoManifiesto.Text = objContenedor.PesoManifiesto.ToString();
                    txtAgenteAduanas.Text = objContenedor.AgenteAduana;
                    txtReserva.Text = objContenedor.Autorizacion.ToString();
                    if (objContenedor.TipoMovimiento =="IMP")
                    {
                        cbTipoMovimiento.SelectedIndex = 0;
                    } else if (objContenedor.TipoMovimiento =="EXP")
                    {
                        cbTipoMovimiento.SelectedIndex = 1;
                    }
                    txtTara.Text = objContenedor.Tara.ToString();
                    cbTamanioContenedor.SelectedValue = objContenedor.TamanoContenedorId;
                    cbTipoContenedor.SelectedValue = objContenedor.TipoContenedorId;
                    txtNumViaje.Text = objContenedor.NumeroViaje;
                    txtEIR.Text = objContenedor.EIR;
                    if (objContenedor.Estado==0)
                    {
                        cbEstado.SelectedIndex = 0;
                    }
                    else if (objContenedor.Estado==1)
                    {
                        cbEstado.SelectedIndex = 1;
                    }
                    txtPrecintoAduanero.Text = objContenedor.PrecintoAduanero;
                    txtPrecinto1.Text = objContenedor.Precinto1;
                    txtPrecinto2.Text = objContenedor.Precinto2;
                    txtPrecinto3.Text = objContenedor.Precinto3;
                    txtUbicacion.Text = objContenedor.Ubicacion;
                    txtNave.Text = objContenedor.Nave.Nombre;
                    dtpFechaIzaje.Value = objContenedor.FechaIzaje.Value.Date;
                    dtpHoraIzaje.Text = objContenedor.FechaIzaje.Value.ToShortTimeString();
                    dtpFechaBarco.Value = objContenedor.FechaBarco.Value.Date;
                    dtpHoraBarco.Text = objContenedor.FechaBarco.Value.ToShortTimeString();
                    dtpFechaMuelle.Value = objContenedor.FechaMuelle.Value.Date;
                    dtpHoraMuelle.Text = objContenedor.FechaMuelle.Value.ToShortTimeString();
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
                if (!ValidarComponentes()) return;
                if (MessageBox.Show(MensajePregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                ContenedorBC objContenedorBC = new ContenedorBC();
                Contenedor objContenedor = new Contenedor();
                objContenedor.Codigo = txtCodigo.Text.ToUpper();
                objContenedor.Embarcadero = txtEmbarcadero.Text.ToUpper();
                objContenedor.PesoManifiesto = Convert.ToDecimal(txtPesoManifiesto.Text.ToString());
                objContenedor.AgenteAduana = txtAgenteAduanas.Text;
                objContenedor.Autorizacion = Convert.ToInt32(txtReserva.Text.ToString());
                if (cbTipoMovimiento.SelectedIndex==0)
                { 
                    objContenedor.TipoMovimiento = "IMP";
                }
                else if (cbTipoMovimiento.SelectedIndex == 1)
                {
                    objContenedor.TipoMovimiento = "EXP";
                }
                objContenedor.Tara =Convert.ToDecimal(txtTara.Text.ToString());
                objContenedor.TamanoContenedorId = Convert.ToInt32(cbTamanioContenedor.SelectedValue.ToString());
                objContenedor.TipoContenedorId = Convert.ToInt32(cbTipoContenedor.SelectedValue.ToString());
                objContenedor.NumeroViaje = txtNumViaje.Text;
                objContenedor.EIR = txtEIR.Text;
                objContenedor.Estado =Convert.ToInt16(cbEstado.SelectedIndex);
                objContenedor.PrecintoAduanero = txtPrecintoAduanero.Text;
                objContenedor.Precinto1 = txtPrecinto1.Text;
                objContenedor.Precinto2 = txtPrecinto2.Text;
                objContenedor.Precinto3 = txtPrecinto3.Text;
                objContenedor.Ubicacion = txtUbicacion.Text.ToUpper();
                objContenedor.NaveId = NaveId;
                objContenedor.Fecha = DateTime.Now;
                objContenedor.FechaIzaje = dtpFechaIzaje.Value.Date + dtpHoraIzaje.Value.TimeOfDay;
                objContenedor.FechaBarco = dtpFechaBarco.Value.Date + dtpHoraBarco.Value.TimeOfDay;
                objContenedor.FechaMuelle = dtpFechaMuelle.Value.Date + dtpHoraMuelle.Value.TimeOfDay;
                if (Modo == TypeMode.Registrar)
                {
                    objContenedorBC.RegistrarContenedor(objContenedor);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objContenedor.ContenedorId = ContenedorId;
                    objContenedorBC.EditarContenedor(objContenedor);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MiDelegado();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                                   this.Text,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarNave_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmNave frm = new frm_AdmNave();
                frm.Modo = frm_AdmNave.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosNave;
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

        public bool ValidarComponentes()
        {
            bool valido=true;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                epTxt.SetError(txtCodigo, "Dato Invalido");
                valido = false;
            }
            else
            {
                epTxt.Clear();

                if (string.IsNullOrWhiteSpace(txtEmbarcadero.Text))
                {
                    epTxt.SetError(txtEmbarcadero, "Dato Invalido");
                    valido = false;
                }
                else
                {
                    epTxt.Clear();

                    if (string.IsNullOrWhiteSpace(txtPesoManifiesto.Text))
                    {
                        epTxt.SetError(txtPesoManifiesto, "Dato Invalido");
                        valido = false;
                    }
                    else
                    {
                        epTxt.Clear();

                        if (string.IsNullOrWhiteSpace(txtAgenteAduanas.Text))
                        {
                            epTxt.SetError(txtAgenteAduanas, "Dato Invalido");
                            valido = false;
                        }
                        else
                        {
                            epTxt.Clear();

                            if (string.IsNullOrWhiteSpace(txtReserva.Text))
                            {
                                epTxt.SetError(txtReserva, "Dato Invalido");
                                valido = false;
                            }
                            else
                            {
                                epTxt.Clear();


                                if (string.IsNullOrWhiteSpace(txtTara.Text))
                                {
                                    epTxt.SetError(txtTara, "Dato Invalido");
                                    valido = false;
                                }
                                else
                                {
                                    epTxt.Clear();

                                    if (string.IsNullOrWhiteSpace(txtNumViaje.Text))
                                {
                                    epTxt.SetError(txtNumViaje, "Dato Invalido");
                                    valido = false;
                                }
                                else
                                {
                                    epTxt.Clear();

                                        if (string.IsNullOrWhiteSpace(txtEIR.Text))
                                        {
                                            epTxt.SetError(txtEIR, "Dato Invalido");
                                            valido = false;
                                        }
                                        else
                                        {
                                            epTxt.Clear();

                                            if (string.IsNullOrWhiteSpace(txtPrecintoAduanero.Text))
                                            {
                                                epTxt.SetError(txtPrecintoAduanero, "Dato Invalido");
                                                valido = false;
                                            }
                                            else
                                            {
                                                epTxt.Clear();

                                                if (string.IsNullOrWhiteSpace(txtPrecinto1.Text))
                                                {
                                                    epTxt.SetError(txtPrecinto1, "Dato Invalido");
                                                    valido = false;
                                                }
                                                else
                                                {
                                                    epTxt.Clear();

                                                    if (string.IsNullOrWhiteSpace(txtPrecinto2.Text))
                                                    {
                                                        epTxt.SetError(txtPrecinto2, "Dato Invalido");
                                                        valido = false;
                                                    }
                                                    else
                                                    {
                                                        epTxt.Clear();

                                                        if (string.IsNullOrWhiteSpace(txtPrecinto3.Text))
                                                        {
                                                            epTxt.SetError(txtPrecinto3, "Dato Invalido");
                                                            valido = false;
                                                        }
                                                        else
                                                        {
                                                            epTxt.Clear();

                                                            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
                                                            {
                                                                epTxt.SetError(txtUbicacion, "Dato Invalido");
                                                                valido = false;
                                                            }
                                                            else
                                                            {
                                                                epTxt.Clear();

                                                                if (string.IsNullOrWhiteSpace(txtNave.Text))
                                                                {
                                                                    epTxt.SetError(txtNave, "Dato Invalido");
                                                                    valido = false;
                                                                }
                                                                else
                                                                {
                                                                    epTxt.Clear();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return valido;
        }
    }
}
