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
    public partial class frm_RegistrarPesaje : Form
    {
        public frm_RegistrarPesaje()
        {
            InitializeComponent();
        }
        public int VehiculoId { get; set; }
        public int ConductorId { get; set; }
        public int AutorizacionId { get; set; }
        public int UsuarioId { get; set; }
        public int NaveId { get; set; }
        public int ContenedorNaveId { get; set; }
        public int PesajeId { get; set; }
        private void RecibirDatosNave(int naveId, string nombre)
        {
            txtExpNaveContenedor.Text = nombre;
            ContenedorNaveId = naveId;
        }

        private void RecibirDatosVehiculo(Vehiculo oVehiculo)
        {
            VehiculoId = oVehiculo.VehiculoId;
            txtPlaca.Text = oVehiculo.Placa;
            txtCarrete.Text = oVehiculo.Carrete;
            cbTipoVehiculo.SelectedValue = oVehiculo.TipoVehiculoId;
        }
        private void RecibirDatosAutorizacion(Autorizacion oAutorizacion)
        {
            AutorizacionId = oAutorizacion.AutorizacionId;
            txtCodigoAutorizacion.Text = oAutorizacion.Codigo;
            txtOperacion.Text = oAutorizacion.Operacion.Codigo + " - " + oAutorizacion.Operacion.Descripcion;
            txtEmbalaje.Text = oAutorizacion.Embalaje.Codigo + " - " + oAutorizacion.Embalaje.Descripcion;
            txtNave.Text = oAutorizacion.Nave.Nombre;
            NaveId = oAutorizacion.NaveId;
            txtPesoAutorizacion.Text = oAutorizacion.Peso.ToString();
            if(oAutorizacion.Tipo == "IMP")
            {
                txtTipo.Text ="IMPORTACION";
            }
            else if (oAutorizacion.Tipo == "EXP")
            {
                txtTipo.Text = "EXPORTACION";
            }
            lblNroBultos.Text = oAutorizacion.NroBultos.ToString();
            
        }
        private void RecibirDatosAutorizacion2(Autorizacion oAutorizacion)
        {
            txtBooking.Text = oAutorizacion.Codigo;
        }
        private void RecibirDatosConductor(int conductorId,string  Nombres,string NroBrevete)
        {
            ConductorId = conductorId;
            txtBrevete.Text = NroBrevete;
            txtNombreConductor.Text = Nombres;
        }
        private void EliminarGuiaInactiva()
        {
            GuiaRemisionBC objGuiaRemisionBC = new GuiaRemisionBC();
            objGuiaRemisionBC.EliminarGuiaInactiva();
            RefrescarGrilla();
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
        public void dgvGuiaRemisionConfigurar()
        {
            dgvGuiaRemision.Columns["GuiaRemisionId"].Visible = false;
            dgvGuiaRemision.Columns["Estado"].Visible = false;
            dgvGuiaRemision.Columns["Pesaje"].Visible = false;
            dgvGuiaRemision.Columns["PesajeId"].Visible = false;
        }
        private void RefrescarGrilla()
        {
            GuiaRemisionBC objGuiaRemisionBC = new GuiaRemisionBC();
            dgvGuiaRemision.DataSource = objGuiaRemisionBC.ListarGuiaRemision();
            dgvGuiaRemisionConfigurar();
        }

        private void ControlarControlesContenedor(bool estado)
        {
            if (estado)
            { 
            txtExpNumContenedor.Enabled = estado;
            txtExpEmbarcadero.Enabled = estado;
            txtExpPesoManifiesto.Enabled = estado;
            txtExpAgenteAduanas.Enabled = estado;
            txtExpReserva.Enabled = estado;
            txtExpTara.Enabled = estado;
            cbTamanio.Enabled = estado;
            cbTipoContenedor.Enabled = estado;
            txtExpNumViaje.Enabled = estado;
            txtExpEIR.Enabled = estado;
            txtExpNaveContenedor.Enabled = estado;
            btnBuscarNave.Enabled = estado;
            txtExpPrecintoAduanero.Enabled = estado;
            txtExpPrecinto1.Enabled = estado;
            txtExpPrecinto2.Enabled = estado;
            txtExpPrecinto3.Enabled = estado;
            txtExpUbicacion.Enabled = estado;
            dtpExpIzajeFec.Enabled = estado;
            dtpExpIzajeHor.Enabled = estado;
            dtpExpMuelleFec.Enabled = estado;
            dtpExpMuelleHor.Enabled = estado;
            dtpExpBarcoFec.Enabled = estado;
            dtpExpBarcoHor.Enabled = estado;
            }
            else
            {
                txtExpNumContenedor.Enabled = estado;
                txtExpEmbarcadero.Enabled = estado;
                txtExpPesoManifiesto.Enabled = estado;
                txtExpAgenteAduanas.Enabled = estado;
                txtExpReserva.Enabled = estado;
                txtExpTara.Enabled = estado;
                cbTamanio.Enabled = estado;
                cbTipoContenedor.Enabled = estado;
                txtExpNumViaje.Enabled = estado;
                txtExpEIR.Enabled = estado;
                txtExpNaveContenedor.Enabled = estado;
                btnBuscarNave.Enabled = estado;
                txtExpPrecintoAduanero.Enabled = estado;
                txtExpPrecinto1.Enabled = estado;
                txtExpPrecinto2.Enabled = estado;
                txtExpPrecinto3.Enabled = estado;
                txtExpUbicacion.Enabled = estado;
                dtpExpIzajeFec.Enabled = estado;
                dtpExpIzajeHor.Enabled = estado;
                dtpExpMuelleFec.Enabled = estado;
                dtpExpMuelleHor.Enabled = estado;
                dtpExpBarcoFec.Enabled = estado;
                dtpExpBarcoHor.Enabled = estado;
                txtExpNumContenedor.Clear();
                txtExpEmbarcadero.Clear();
                txtExpPesoManifiesto.Clear();
                txtExpAgenteAduanas.Clear();
                txtExpReserva.Clear();
                txtExpTara.Clear();
                cbTamanio.SelectedIndex = 0;
                cbTipoContenedor.SelectedIndex = 0;
                txtExpNumViaje.Clear();
                txtExpEIR.Clear();
                txtExpNaveContenedor.Clear();
                txtExpPrecintoAduanero.Clear();
                txtExpPrecinto1.Clear();
                txtExpPrecinto2.Clear();
                txtExpPrecinto3.Clear();
                txtExpUbicacion.Clear();
                dtpExpIzajeFec.Value = DateTime.Now;
                dtpExpIzajeHor.Value = DateTime.Now;
                dtpExpMuelleFec.Value = DateTime.Now;
                dtpExpMuelleHor.Value = DateTime.Now;
                dtpExpBarcoFec.Value = DateTime.Now;
                dtpExpBarcoHor.Value = DateTime.Now;
            }
        }
        private void frm_RegistrarPesaje_Load(object sender, EventArgs e)
        {
            try
            {
               
                
                ConfigurarControles(dgvGuiaRemision);
                RefrescarGrilla();
                TipoContenedorBC objTipoContenedorBC = new TipoContenedorBC();
                cbTipoContenedor.DataSource = objTipoContenedorBC.ListarTipoContenedor();
                cbTipoContenedor.DisplayMember = "Descripcion";
                cbTipoContenedor.ValueMember = "TipoContenedorId";
                TamanioContenedorBC objTamanioContenedorBC = new TamanioContenedorBC();
                cbTamanio.DataSource = objTamanioContenedorBC.ListarTamanioContenedor();
                cbTamanio.DisplayMember = "Descripcion";
                cbTamanio.ValueMember = "TamanioContenedorId";
                TipoVehiculoBC objTipoVehiculoBC = new TipoVehiculoBC();
                cbTipoVehiculo.DataSource = objTipoVehiculoBC.ListarTipoVehiculo();
                cbTipoVehiculo.DisplayMember = "Nombre";
                cbTipoVehiculo.ValueMember = "TipoVehiculoId";
                ControlarControlesContenedor(false);
            }
            catch (Exception ex )
            {
                
              MessageBox.Show(ex.ToString(),
                                   this.Text,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmVehiculo frm = new frm_AdmVehiculo();
                frm.Modo = frm_AdmVehiculo.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosVehiculo;
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

        private void btnBuscarConductor_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmConductor frm = new frm_AdmConductor();
                frm.Modo = frm_AdmConductor.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosConductor;
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

        private void btnBuscarAutorizacion_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmAutorizacion frm = new frm_AdmAutorizacion();
                frm.Modo = frm_AdmAutorizacion.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosAutorizacion;
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

        private void btnRegistrarGuia_Click(object sender, EventArgs e)
        {
            try
            {
                frm_GuiaRemision frm = new frm_GuiaRemision();
                frm.Modo = frm_GuiaRemision.TypeMode.Registrar;
                frm.MiDelegado = RefrescarGrilla;
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

        private void btnEliminarGuia_Click(object sender, EventArgs e)
        {
            try { 
                if (dgvGuiaRemision.SelectedRows.Count>0)
                {
                    if (MessageBox.Show("¿Está seguro que quiere eliminar la guia de Reminisión: " + dgvGuiaRemision.SelectedRows[0].Cells["Documento"].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    GuiaRemisionBC objGuiaRemisionBC = new GuiaRemisionBC();
                    objGuiaRemisionBC.EliminarGuiaRemision(Convert.ToInt32(dgvGuiaRemision.SelectedRows[0].Cells["GuiaRemisionId"].Value));
                    RefrescarGrilla();
                    MessageBox.Show("Se eliminó satisfactoriamente la Guia de Remisión.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                if (dgvGuiaRemision.RowCount > 0)
                {
                    if (MessageBox.Show("Perderá los datos si sale del formulario. ¿Desea Continuar?",
                                      this.Text,
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        EliminarGuiaInactiva();
                    }
                }
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

        private void frm_RegistrarPesaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(dgvGuiaRemision.RowCount>0)
                { 
                    if (MessageBox.Show("Perderá los datos si sale del formulario. ¿Desea Continuar?",
                                      this.Text,
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                        EliminarGuiaInactiva();
                    }
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

        private void btnEditarGuia_Click(object sender, EventArgs e)
        {
            try
            {
                frm_GuiaRemision frm = new frm_GuiaRemision();
                frm.Modo = frm_GuiaRemision.TypeMode.Editar;
                frm.GuiaRemisionId = Convert.ToInt32(dgvGuiaRemision.SelectedRows[0].Cells["GuiaRemisionId"].Value);
                frm.MiDelegado = RefrescarGrilla;
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
        
        private void chkHabRegCont_CheckedChanged(object sender, EventArgs e)
        {
            ControlarControlesContenedor(chkHabRegCont.Checked);
        }

        private void btnBuscarAutorizacion2_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmAutorizacion frm = new frm_AdmAutorizacion();
                frm.Modo = frm_AdmAutorizacion.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosAutorizacion2;
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

        private void txtBooking_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AutorizacionBC objAutorizacionBC = new AutorizacionBC();
                cbContenedor.DataSource = objAutorizacionBC.FiltrarContenedores(txtBooking.Text);
                cbContenedor.DisplayMember = "Codigo";
                cbContenedor.ValueMember = "ContenedorId";
            }
            catch (Exception)
            {
                      MessageBox.Show("Disculpe, el sistema se encuentra fuera de servicio!",
                                  this.Text,
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
            
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtPeso.Text = rnd.Next(10000, 20000).ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de registrar un Pesaje?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (chkHabRegCont.Checked)
            {
                ContenedorBC objContenedorBC = new ContenedorBC();
                Contenedor objContenedor = new Contenedor();
                objContenedor.Codigo = txtExpNumContenedor.Text.ToUpper();
                objContenedor.Embarcadero = txtExpEmbarcadero.Text.ToUpper();
                objContenedor.PesoManifiesto = Convert.ToDecimal(txtExpPesoManifiesto.Text.ToString());
                objContenedor.AgenteAduana = txtExpAgenteAduanas.Text;
                objContenedor.Autorizacion = Convert.ToInt32(txtExpReserva.Text.ToString());
                objContenedor.TipoMovimiento = "EXP";
                objContenedor.Tara = Convert.ToDecimal(txtExpTara.Text.ToString());
                objContenedor.TamanoContenedorId = Convert.ToInt32(cbTamanio.SelectedValue.ToString());
                objContenedor.TipoContenedorId = Convert.ToInt32(cbTipoContenedor.SelectedValue.ToString());
                objContenedor.NumeroViaje = txtExpNumViaje.Text;
                objContenedor.EIR = txtExpEIR.Text;
                objContenedor.Estado = 1;
                objContenedor.PrecintoAduanero = txtExpPrecintoAduanero.Text;
                objContenedor.Precinto1 = txtExpPrecinto1.Text;
                objContenedor.Precinto2 = txtExpPrecinto2.Text;
                objContenedor.Precinto3 = txtExpPrecinto3.Text;
                objContenedor.Ubicacion = txtExpUbicacion.Text.ToUpper();
                objContenedor.NaveId = NaveId;
                objContenedor.Fecha = DateTime.Now;
                objContenedor.FechaIzaje = dtpExpIzajeFec.Value.Date + dtpExpIzajeHor.Value.TimeOfDay;
                objContenedor.FechaBarco = dtpExpBarcoFec.Value.Date + dtpExpBarcoHor.Value.TimeOfDay;
                objContenedor.FechaMuelle = dtpExpMuelleFec.Value.Date + dtpExpMuelleHor.Value.TimeOfDay;
                objContenedorBC.RegistrarContenedor(objContenedor);
            }
            PesajeBC objPesajeBC = new PesajeBC();
            Pesaje objPesaje = new Pesaje();
            objPesaje.UsuarioId = UsuarioId;
            objPesaje.ConductorId = ConductorId;
            objPesaje.VehiculoId = VehiculoId;
            objPesaje.AutorizacionId = AutorizacionId;
            objPesaje.Observacion = txtObservacion.Text.Trim().ToUpper();
            objPesaje.Fecha = DateTime.Today;
            objPesaje.Estado = 1;
            objPesaje.Bruto = Convert.ToDecimal(txtPeso.Text.ToString());
            objPesaje.Neto = Convert.ToDecimal(txtPesoAutorizacion.Text.ToString());
            objPesaje.NaveId = NaveId;
            objPesaje.Tarja =Convert.ToInt32(nudTarja.Value.ToString());
            objPesaje.Bultos = Convert.ToInt32(lblNroBultos.Text.ToString());
            objPesaje.HoraGancho = DateTime.Now;
            objPesaje.CodContenedor = cbContenedor.SelectedValue.ToString();
            if (txtTipo.Text == "EXPORTACION")
             objPesaje.Tipo = "EXP"; 
            else
             objPesaje.Tipo = "IMP"; 
            objPesajeBC.RegistrarPesaje(objPesaje);
            GuiaRemisionBC objGuiaRemisionBC = new GuiaRemisionBC();
            PesajeId = objPesajeBC.BuscarUltimoIdPesaje();
            objGuiaRemisionBC.ActualizarIdGuiaRemision(PesajeId);
            MessageBox.Show("Se registró satisfactoriamente el Pesaje", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
