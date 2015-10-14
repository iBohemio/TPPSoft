using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPP.DL.DataModel;
using TPP.BL.BC;
namespace TPP.UI
{
    public partial class frm_Autorizacion : Form
    {
        public frm_Autorizacion()
        {
            InitializeComponent();
        }
        public int UsuarioId { get; set; }
        public int EmbalajeId { get; set; }
        public int OperacionId { get; set; }
        public int NaveId { get; set; }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int AutorizacionId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void RecibirDatosEmbalaje(int embalajeId,string codigo, string descripcion)
        {
            EmbalajeId = embalajeId;
            txtEmbalaje.Text = codigo;
            txtResEmbalaje.Text = descripcion;
        }
        private void RecibirDatosOperacion(int operacionId, string codigo, string descripcion)
        {
            OperacionId = operacionId;
            txtOperacion.Text = codigo;
            txtResOperacion.Text = descripcion;
        }
        private void RecibirDatosNave(int naveId,string nombre)
        {
            NaveId = naveId;
            txtNave.Text = nombre;
        }
        private void frm_Autorizacion_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Autorización";
                if (Modo == TypeMode.Registrar)
                {
                    lblAutorizacion.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                    UsuarioBC objUsuarioBC = new UsuarioBC();
                    Usuario objUsuario = objUsuarioBC.BuscarUsuario(UsuarioId);
                    lblUsuario.Text = objUsuario.Codigo;
                    cbTipo.SelectedIndex = 0;
                    rdbActivo.Checked=true;
                    lblFechaNombre.Visible = false;
                    lblFecha.Visible = false;
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblFecha.Visible = true;
                    lblFechaNombre.Visible = true;
                    lblAutorizacion.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    AutorizacionBC objAutorizacionBC = new AutorizacionBC();
                    Autorizacion objAutorizacion = objAutorizacionBC.BuscarAutorizacion(AutorizacionId);
                    lblUsuario.Text = objAutorizacion.Usuario.Codigo;
                    txtCodigo.Text = objAutorizacion.Codigo;
                    txtProducto.Text = objAutorizacion.Producto;
                    txtEmbalaje.Text = objAutorizacion.Embalaje.Codigo;
                    txtResEmbalaje.Text = objAutorizacion.Embalaje.Descripcion;
                    txtOperacion.Text = objAutorizacion.Operacion.Codigo;
                    txtResOperacion.Text = objAutorizacion.Operacion.Descripcion;
                    nudBultos.Value = objAutorizacion.NroBultos;
                    nudPesoMaximo.Value = objAutorizacion.Peso;
                    txtNave.Text = objAutorizacion.Nave.Nombre;
                    lblFecha.Text = objAutorizacion.Fecha.ToString();
                    if (objAutorizacion.Tipo.ToString()=="IMP")
                    {
                        cbTipo.SelectedIndex = 0;
                    }
                    else if (objAutorizacion.Tipo.ToString() == "EXP")
                    {
                        cbTipo.SelectedIndex = 1;
                    }
                    if(objAutorizacion.Estado==0)
                    {
                        rdbFinalizado.Checked=true;
                        rdbActivo.Checked = false;
                    }
                    else if (objAutorizacion.Estado == 1)
                    {
                        rdbFinalizado.Checked = false;
                        rdbActivo.Checked = true;
                    }
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
                AutorizacionBC objAutorizacionBC = new AutorizacionBC();
                Autorizacion objAutorizacion = new Autorizacion();
                objAutorizacion.UsuarioId = UsuarioId;
                objAutorizacion.Codigo = txtCodigo.Text;
                objAutorizacion.Producto = txtProducto.Text;
                objAutorizacion.EmbalajeId = EmbalajeId;
                objAutorizacion.OperacionId = OperacionId;
                objAutorizacion.NroBultos =Convert.ToInt32(nudBultos.Value);
                objAutorizacion.Peso = nudPesoMaximo.Value;
                objAutorizacion.NaveId = NaveId;
                objAutorizacion.Fecha = DateTime.Now;
                if (cbTipo.SelectedIndex==0)
                {
                    objAutorizacion.Tipo = "IMP";
                }
                else if (cbTipo.SelectedIndex==1)
                {
                    objAutorizacion.Tipo = "EXP";
                }
                if (rdbActivo.Checked)
                {
                    objAutorizacion.Estado = 1;
                }
                else if (rdbFinalizado.Checked)
                {
                    objAutorizacion.Estado = 0;
                }

                if (Modo == TypeMode.Registrar)
                {
                    objAutorizacionBC.RegistrarAutorizacion(objAutorizacion);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objAutorizacion.AutorizacionId = AutorizacionId;
                    objAutorizacionBC.EditarAutorizacion(objAutorizacion);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MiDelegado();
                this.Dispose();
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

        private void btnBuscarEmbalaje_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmEmbalaje frm = new frm_AdmEmbalaje();
                frm.Modo = frm_AdmEmbalaje.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosEmbalaje;
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

        private void btnBuscarOperacion_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AdmOperacion frm = new frm_AdmOperacion();
                frm.Modo = frm_AdmOperacion.TypeMode.Buscar;
                frm.MiDelegado += RecibirDatosOperacion;
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
