namespace TPP.UI
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.miTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.miContedorbal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegistrarPesaje = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.miControlarPesaje = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReimpresion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEntidad = new System.Windows.Forms.ToolStripMenuItem();
            this.miEje = new System.Windows.Forms.ToolStripMenuItem();
            this.miVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.miConductor = new System.Windows.Forms.ToolStripMenuItem();
            this.miAutorizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmbalaje = new System.Windows.Forms.ToolStripMenuItem();
            this.miOperacion = new System.Windows.Forms.ToolStripMenuItem();
            this.miTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.miNave = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.miTipoContenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miTamanioContenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miContenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.sSPrincipal = new System.Windows.Forms.StatusStrip();
            this.sslbl_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslbl_Rol = new System.Windows.Forms.ToolStripStatusLabel();
            this.miTipoVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.sSPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCerrarSesion,
            this.tsAdministrar,
            this.tsEntrada,
            this.tsSalida,
            this.tsReimpresion,
            this.tsEntidad});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(602, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsCerrarSesion
            // 
            this.tsCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsCerrarSesion.Image")));
            this.tsCerrarSesion.Name = "tsCerrarSesion";
            this.tsCerrarSesion.Size = new System.Drawing.Size(104, 20);
            this.tsCerrarSesion.Text = "Cerrar Sesión";
            this.tsCerrarSesion.Click += new System.EventHandler(this.tsCerrarSesion_Click);
            // 
            // tsAdministrar
            // 
            this.tsAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTicket,
            this.miContedorbal});
            this.tsAdministrar.Image = ((System.Drawing.Image)(resources.GetObject("tsAdministrar.Image")));
            this.tsAdministrar.Name = "tsAdministrar";
            this.tsAdministrar.Size = new System.Drawing.Size(97, 20);
            this.tsAdministrar.Text = "Administrar";
            this.tsAdministrar.Click += new System.EventHandler(this.tsEntidad_Click);
            // 
            // miTicket
            // 
            this.miTicket.Image = ((System.Drawing.Image)(resources.GetObject("miTicket.Image")));
            this.miTicket.Name = "miTicket";
            this.miTicket.Size = new System.Drawing.Size(137, 22);
            this.miTicket.Text = "Ticket";
            // 
            // miContedorbal
            // 
            this.miContedorbal.Image = ((System.Drawing.Image)(resources.GetObject("miContedorbal.Image")));
            this.miContedorbal.Name = "miContedorbal";
            this.miContedorbal.Size = new System.Drawing.Size(137, 22);
            this.miContedorbal.Text = "Contenedor";
            // 
            // tsEntrada
            // 
            this.tsEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRegistrarPesaje});
            this.tsEntrada.Image = ((System.Drawing.Image)(resources.GetObject("tsEntrada.Image")));
            this.tsEntrada.Name = "tsEntrada";
            this.tsEntrada.Size = new System.Drawing.Size(75, 20);
            this.tsEntrada.Text = "Entrada";
            // 
            // miRegistrarPesaje
            // 
            this.miRegistrarPesaje.Image = ((System.Drawing.Image)(resources.GetObject("miRegistrarPesaje.Image")));
            this.miRegistrarPesaje.Name = "miRegistrarPesaje";
            this.miRegistrarPesaje.Size = new System.Drawing.Size(156, 22);
            this.miRegistrarPesaje.Text = "Registrar Pesaje";
            this.miRegistrarPesaje.Click += new System.EventHandler(this.miRegistrarPesaje_Click);
            // 
            // tsSalida
            // 
            this.tsSalida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miControlarPesaje});
            this.tsSalida.Image = ((System.Drawing.Image)(resources.GetObject("tsSalida.Image")));
            this.tsSalida.Name = "tsSalida";
            this.tsSalida.Size = new System.Drawing.Size(66, 20);
            this.tsSalida.Text = "Salida";
            // 
            // miControlarPesaje
            // 
            this.miControlarPesaje.Image = ((System.Drawing.Image)(resources.GetObject("miControlarPesaje.Image")));
            this.miControlarPesaje.Name = "miControlarPesaje";
            this.miControlarPesaje.Size = new System.Drawing.Size(160, 22);
            this.miControlarPesaje.Text = "Controlar Pesaje";
            this.miControlarPesaje.Click += new System.EventHandler(this.miControlarPesaje_Click);
            // 
            // tsReimpresion
            // 
            this.tsReimpresion.Image = ((System.Drawing.Image)(resources.GetObject("tsReimpresion.Image")));
            this.tsReimpresion.Name = "tsReimpresion";
            this.tsReimpresion.Size = new System.Drawing.Size(101, 20);
            this.tsReimpresion.Text = "Reimpresión";
            // 
            // tsEntidad
            // 
            this.tsEntidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEje,
            this.miVehiculo,
            this.miTipoVehiculo,
            this.miConductor,
            this.miAutorizacion,
            this.miEmbalaje,
            this.miOperacion,
            this.miTurno,
            this.miNave,
            this.miUsuario,
            this.miTipoContenedor,
            this.miTamanioContenedor,
            this.miContenedor});
            this.tsEntidad.Image = ((System.Drawing.Image)(resources.GetObject("tsEntidad.Image")));
            this.tsEntidad.Name = "tsEntidad";
            this.tsEntidad.Size = new System.Drawing.Size(75, 20);
            this.tsEntidad.Text = "Entidad";
            // 
            // miEje
            // 
            this.miEje.Image = ((System.Drawing.Image)(resources.GetObject("miEje.Image")));
            this.miEje.Name = "miEje";
            this.miEje.Size = new System.Drawing.Size(200, 22);
            this.miEje.Text = "Eje";
            this.miEje.Click += new System.EventHandler(this.miEje_Click);
            // 
            // miVehiculo
            // 
            this.miVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("miVehiculo.Image")));
            this.miVehiculo.Name = "miVehiculo";
            this.miVehiculo.Size = new System.Drawing.Size(200, 22);
            this.miVehiculo.Text = "Vehiculo";
            this.miVehiculo.Click += new System.EventHandler(this.miVehiculo_Click);
            // 
            // miConductor
            // 
            this.miConductor.Image = ((System.Drawing.Image)(resources.GetObject("miConductor.Image")));
            this.miConductor.Name = "miConductor";
            this.miConductor.Size = new System.Drawing.Size(200, 22);
            this.miConductor.Text = "Conductor";
            this.miConductor.Click += new System.EventHandler(this.miConductor_Click);
            // 
            // miAutorizacion
            // 
            this.miAutorizacion.Image = ((System.Drawing.Image)(resources.GetObject("miAutorizacion.Image")));
            this.miAutorizacion.Name = "miAutorizacion";
            this.miAutorizacion.Size = new System.Drawing.Size(200, 22);
            this.miAutorizacion.Text = "Autorización";
            this.miAutorizacion.Click += new System.EventHandler(this.miAutorizacion_Click);
            // 
            // miEmbalaje
            // 
            this.miEmbalaje.Image = ((System.Drawing.Image)(resources.GetObject("miEmbalaje.Image")));
            this.miEmbalaje.Name = "miEmbalaje";
            this.miEmbalaje.Size = new System.Drawing.Size(200, 22);
            this.miEmbalaje.Text = "Embalaje";
            this.miEmbalaje.Click += new System.EventHandler(this.miEmbalaje_Click);
            // 
            // miOperacion
            // 
            this.miOperacion.Image = ((System.Drawing.Image)(resources.GetObject("miOperacion.Image")));
            this.miOperacion.Name = "miOperacion";
            this.miOperacion.Size = new System.Drawing.Size(200, 22);
            this.miOperacion.Text = "Operación";
            this.miOperacion.Click += new System.EventHandler(this.miOperacion_Click);
            // 
            // miTurno
            // 
            this.miTurno.Image = ((System.Drawing.Image)(resources.GetObject("miTurno.Image")));
            this.miTurno.Name = "miTurno";
            this.miTurno.Size = new System.Drawing.Size(200, 22);
            this.miTurno.Text = "Turno";
            this.miTurno.Click += new System.EventHandler(this.miTurno_Click);
            // 
            // miNave
            // 
            this.miNave.Image = ((System.Drawing.Image)(resources.GetObject("miNave.Image")));
            this.miNave.Name = "miNave";
            this.miNave.Size = new System.Drawing.Size(200, 22);
            this.miNave.Text = "Nave";
            this.miNave.Click += new System.EventHandler(this.miNave_Click);
            // 
            // miUsuario
            // 
            this.miUsuario.Image = ((System.Drawing.Image)(resources.GetObject("miUsuario.Image")));
            this.miUsuario.Name = "miUsuario";
            this.miUsuario.Size = new System.Drawing.Size(200, 22);
            this.miUsuario.Text = "Usuario";
            this.miUsuario.Click += new System.EventHandler(this.miUsuario_Click);
            // 
            // miTipoContenedor
            // 
            this.miTipoContenedor.Image = ((System.Drawing.Image)(resources.GetObject("miTipoContenedor.Image")));
            this.miTipoContenedor.Name = "miTipoContenedor";
            this.miTipoContenedor.Size = new System.Drawing.Size(200, 22);
            this.miTipoContenedor.Text = "Tipo de Contenedor";
            this.miTipoContenedor.Click += new System.EventHandler(this.miTipoContenedor_Click);
            // 
            // miTamanioContenedor
            // 
            this.miTamanioContenedor.Image = ((System.Drawing.Image)(resources.GetObject("miTamanioContenedor.Image")));
            this.miTamanioContenedor.Name = "miTamanioContenedor";
            this.miTamanioContenedor.Size = new System.Drawing.Size(200, 22);
            this.miTamanioContenedor.Text = "Tamaño de Contenedor";
            this.miTamanioContenedor.Click += new System.EventHandler(this.miTamanioContenedor_Click);
            // 
            // miContenedor
            // 
            this.miContenedor.Image = ((System.Drawing.Image)(resources.GetObject("miContenedor.Image")));
            this.miContenedor.Name = "miContenedor";
            this.miContenedor.Size = new System.Drawing.Size(200, 22);
            this.miContenedor.Text = "Contenedor";
            this.miContenedor.Click += new System.EventHandler(this.miContenedor_Click);
            // 
            // sSPrincipal
            // 
            this.sSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslbl_Usuario,
            this.sslbl_Rol});
            this.sSPrincipal.Location = new System.Drawing.Point(0, 346);
            this.sSPrincipal.Name = "sSPrincipal";
            this.sSPrincipal.Size = new System.Drawing.Size(602, 24);
            this.sSPrincipal.TabIndex = 1;
            this.sSPrincipal.Text = "statusStrip1";
            // 
            // sslbl_Usuario
            // 
            this.sslbl_Usuario.Name = "sslbl_Usuario";
            this.sslbl_Usuario.Size = new System.Drawing.Size(66, 19);
            this.sslbl_Usuario.Text = "Bienvenido";
            // 
            // sslbl_Rol
            // 
            this.sslbl_Rol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sslbl_Rol.Name = "sslbl_Rol";
            this.sslbl_Rol.Size = new System.Drawing.Size(14, 19);
            this.sslbl_Rol.Text = ".";
            // 
            // miTipoVehiculo
            // 
            this.miTipoVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("miTipoVehiculo.Image")));
            this.miTipoVehiculo.Name = "miTipoVehiculo";
            this.miTipoVehiculo.Size = new System.Drawing.Size(200, 22);
            this.miTipoVehiculo.Text = "Tipo de vehículo";
            this.miTipoVehiculo.Click += new System.EventHandler(this.miTipoVehiculo_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 370);
            this.Controls.Add(this.sSPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPP - ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.sSPrincipal.ResumeLayout(false);
            this.sSPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.StatusStrip sSPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarSesion;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_Usuario;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_Rol;
        private System.Windows.Forms.ToolStripMenuItem tsAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tsEntrada;
        private System.Windows.Forms.ToolStripMenuItem tsSalida;
        private System.Windows.Forms.ToolStripMenuItem tsReimpresion;
        private System.Windows.Forms.ToolStripMenuItem tsEntidad;
        private System.Windows.Forms.ToolStripMenuItem miEje;
        private System.Windows.Forms.ToolStripMenuItem miVehiculo;
        private System.Windows.Forms.ToolStripMenuItem miConductor;
        private System.Windows.Forms.ToolStripMenuItem miAutorizacion;
        private System.Windows.Forms.ToolStripMenuItem miEmbalaje;
        private System.Windows.Forms.ToolStripMenuItem miOperacion;
        private System.Windows.Forms.ToolStripMenuItem miTurno;
        private System.Windows.Forms.ToolStripMenuItem miNave;
        private System.Windows.Forms.ToolStripMenuItem miUsuario;
        private System.Windows.Forms.ToolStripMenuItem miTipoContenedor;
        private System.Windows.Forms.ToolStripMenuItem miTamanioContenedor;
        private System.Windows.Forms.ToolStripMenuItem miContenedor;
        private System.Windows.Forms.ToolStripMenuItem miRegistrarPesaje;
        private System.Windows.Forms.ToolStripMenuItem miControlarPesaje;
        private System.Windows.Forms.ToolStripMenuItem miTicket;
        private System.Windows.Forms.ToolStripMenuItem miContedorbal;
        private System.Windows.Forms.ToolStripMenuItem miTipoVehiculo;
    }
}

