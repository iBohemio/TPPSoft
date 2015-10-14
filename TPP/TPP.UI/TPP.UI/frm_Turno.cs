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
    public partial class frm_Turno : Form
    {
        public frm_Turno()
        {
            InitializeComponent();
        }
        public enum TypeMode { Registrar, Editar }
        public TypeMode Modo { get; set; }
        public int TurnoId { get; set; }
        public delegate void dlgRefrescarGrilla();
        public dlgRefrescarGrilla MiDelegado;
        private string MensajePregunta;
        private string MensajeRespuesta;
        private string Entidad;
        private void frm_Turno_Load(object sender, EventArgs e)
        {
            try
            {
                Entidad = "Turno";
                if (Modo == TypeMode.Registrar)
                {
                    lblTurno.Text = "Registrar " + Entidad;
                    btnRegistrar.Text = "Registrar";
                    MensajePregunta = "¿Está seguro de registrar el " + Entidad + "?";
                    MensajeRespuesta = "Se registró el " + Entidad + " satisfactoriamente.";
                    cbHoraIni.SelectedIndex = cbMinIni.SelectedIndex = cbMinFin.SelectedIndex = cbHoraFin.SelectedIndex = 0;
               
                }
                else if (Modo == TypeMode.Editar)
                {
                    lblTurno.Text = "Editar " + Entidad;
                    btnRegistrar.Text = "Editar";
                    MensajePregunta = "¿Está seguro de editar el " + Entidad + "?";
                    MensajeRespuesta = "Se editó el " + Entidad + " satisfactoriamente.";
                    TurnoBC objTurnoBC = new TurnoBC();
                    Turno objTurno = objTurnoBC.BuscarTurno(TurnoId);
                    txtNombre.Text = objTurno.Nombre;
                    cbHoraIni.SelectedItem = objTurno.HoraInicio.ToString();
                    cbMinIni.SelectedItem = objTurno.MinutoInicio.ToString();
                    cbHoraFin.SelectedItem = objTurno.HoraFin.ToString();
                    cbMinFin.SelectedItem = objTurno.MinutoFin.ToString();
                }
                 txtNombre.Focus();
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
                TurnoBC objTurnoBC = new TurnoBC();
                Turno objTurno = new Turno();
                objTurno.Nombre = txtNombre.Text.ToUpper();
                objTurno.HoraInicio =Convert.ToInt32(cbHoraIni.Text);
                objTurno.MinutoInicio = Convert.ToInt32(cbMinIni.Text);
                objTurno.HoraFin = Convert.ToInt32(cbHoraFin.Text);
                objTurno.MinutoFin = Convert.ToInt32(cbMinFin.Text);
                objTurno.Estado = 1;
                if (Modo == TypeMode.Registrar)
                {
                    objTurnoBC.RegistrarTurno(objTurno);
                    MessageBox.Show(MensajeRespuesta, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Modo == TypeMode.Editar)
                {
                    objTurno.TurnoId = TurnoId;
                    objTurnoBC.EditarTurno(objTurno);
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
