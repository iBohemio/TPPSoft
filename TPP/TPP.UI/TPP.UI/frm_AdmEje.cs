using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPP.UI
{
    public partial class frm_AdmEje : Form
    {
        public frm_AdmEje()
        {
            InitializeComponent();
        }

        private void RefrescarGrilla()
        {
            //DistritoBC objDistritoBC = new DistritoBC();
            //dgvDistrito.DataSource = objDistritoBC.DistritoListar();
            //dgvDistritoConfigurar();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frm_Eje frm = new frm_Eje();
            frm.Modo = frm_Eje.TypeMode.Registrar;
            frm.MiDelegado += RefrescarGrilla;
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frm_Eje frm = new frm_Eje();
            frm.Modo = frm_Eje.TypeMode.Editar;
            frm.MiDelegado += RefrescarGrilla;
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
