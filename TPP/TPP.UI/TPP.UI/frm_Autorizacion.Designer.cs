namespace TPP.UI
{
    partial class frm_Autorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Autorizacion));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmbalaje = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAutorizacion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscarEmbalaje = new System.Windows.Forms.Button();
            this.btnBuscarOperacion = new System.Windows.Forms.Button();
            this.txtResEmbalaje = new System.Windows.Forms.TextBox();
            this.txtResOperacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPesoMaximo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudBultos = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.txtNave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbFinalizado = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBultos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 20);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(220, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Código:";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(139, 116);
            this.txtOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.ReadOnly = true;
            this.txtOperacion.Size = new System.Drawing.Size(118, 22);
            this.txtOperacion.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Operación:";
            // 
            // txtEmbalaje
            // 
            this.txtEmbalaje.Location = new System.Drawing.Point(139, 84);
            this.txtEmbalaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmbalaje.Name = "txtEmbalaje";
            this.txtEmbalaje.ReadOnly = true;
            this.txtEmbalaje.Size = new System.Drawing.Size(118, 22);
            this.txtEmbalaje.TabIndex = 42;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(139, 52);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(220, 22);
            this.txtProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Embalaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Producto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAutorizacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 60);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAutorizacion
            // 
            this.lblAutorizacion.AutoSize = true;
            this.lblAutorizacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizacion.ForeColor = System.Drawing.Color.White;
            this.lblAutorizacion.Location = new System.Drawing.Point(51, 25);
            this.lblAutorizacion.Name = "lblAutorizacion";
            this.lblAutorizacion.Size = new System.Drawing.Size(88, 16);
            this.lblAutorizacion.TabIndex = 1;
            this.lblAutorizacion.Text = "Autorización";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(576, 436);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(20, 436);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 37);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(75, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblUsuario.TabIndex = 48;
            this.lblUsuario.Text = "[Usuario]";
            // 
            // btnBuscarEmbalaje
            // 
            this.btnBuscarEmbalaje.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmbalaje.Image")));
            this.btnBuscarEmbalaje.Location = new System.Drawing.Point(263, 83);
            this.btnBuscarEmbalaje.Name = "btnBuscarEmbalaje";
            this.btnBuscarEmbalaje.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarEmbalaje.TabIndex = 2;
            this.btnBuscarEmbalaje.UseVisualStyleBackColor = true;
            this.btnBuscarEmbalaje.Click += new System.EventHandler(this.btnBuscarEmbalaje_Click);
            // 
            // btnBuscarOperacion
            // 
            this.btnBuscarOperacion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOperacion.Image")));
            this.btnBuscarOperacion.Location = new System.Drawing.Point(263, 115);
            this.btnBuscarOperacion.Name = "btnBuscarOperacion";
            this.btnBuscarOperacion.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarOperacion.TabIndex = 3;
            this.btnBuscarOperacion.UseVisualStyleBackColor = true;
            this.btnBuscarOperacion.Click += new System.EventHandler(this.btnBuscarOperacion_Click);
            // 
            // txtResEmbalaje
            // 
            this.txtResEmbalaje.Location = new System.Drawing.Point(295, 84);
            this.txtResEmbalaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResEmbalaje.Name = "txtResEmbalaje";
            this.txtResEmbalaje.ReadOnly = true;
            this.txtResEmbalaje.Size = new System.Drawing.Size(352, 22);
            this.txtResEmbalaje.TabIndex = 51;
            // 
            // txtResOperacion
            // 
            this.txtResOperacion.Location = new System.Drawing.Point(295, 116);
            this.txtResOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResOperacion.Name = "txtResOperacion";
            this.txtResOperacion.ReadOnly = true;
            this.txtResOperacion.Size = new System.Drawing.Size(352, 22);
            this.txtResOperacion.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Bultos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kg.";
            // 
            // nudPesoMaximo
            // 
            this.nudPesoMaximo.Location = new System.Drawing.Point(138, 175);
            this.nudPesoMaximo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPesoMaximo.Name = "nudPesoMaximo";
            this.nudPesoMaximo.Size = new System.Drawing.Size(151, 22);
            this.nudPesoMaximo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Peso Máximo:";
            // 
            // nudBultos
            // 
            this.nudBultos.Location = new System.Drawing.Point(138, 147);
            this.nudBultos.Name = "nudBultos";
            this.nudBultos.Size = new System.Drawing.Size(151, 22);
            this.nudBultos.TabIndex = 4;
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNave.Image")));
            this.btnBuscarNave.Location = new System.Drawing.Point(263, 207);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarNave.TabIndex = 6;
            this.btnBuscarNave.UseVisualStyleBackColor = true;
            this.btnBuscarNave.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // txtNave
            // 
            this.txtNave.Location = new System.Drawing.Point(139, 208);
            this.txtNave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNave.Name = "txtNave";
            this.txtNave.ReadOnly = true;
            this.txtNave.Size = new System.Drawing.Size(118, 22);
            this.txtNave.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Nave:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "IMPORTACIÓN",
            "EXPORTACIÓN"});
            this.cbTipo.Location = new System.Drawing.Point(139, 241);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(183, 24);
            this.cbTipo.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Estado:";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(139, 277);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(61, 20);
            this.rdbActivo.TabIndex = 8;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbFinalizado
            // 
            this.rdbFinalizado.AutoSize = true;
            this.rdbFinalizado.Location = new System.Drawing.Point(237, 277);
            this.rdbFinalizado.Name = "rdbFinalizado";
            this.rdbFinalizado.Size = new System.Drawing.Size(85, 20);
            this.rdbFinalizado.TabIndex = 9;
            this.rdbFinalizado.TabStop = true;
            this.rdbFinalizado.Text = "Finalizado";
            this.rdbFinalizado.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(434, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 16);
            this.lblFecha.TabIndex = 66;
            this.lblFecha.Text = "[Fecha]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Location = new System.Drawing.Point(19, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 51);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales del Registro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdbFinalizado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdbActivo);
            this.groupBox2.Controls.Add(this.txtEmbalaje);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTipo);
            this.groupBox2.Controls.Add(this.txtOperacion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBuscarNave);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtNave);
            this.groupBox2.Controls.Add(this.btnBuscarEmbalaje);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnBuscarOperacion);
            this.groupBox2.Controls.Add(this.nudBultos);
            this.groupBox2.Controls.Add(this.txtResEmbalaje);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtResOperacion);
            this.groupBox2.Controls.Add(this.nudPesoMaximo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(19, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 303);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Autorización";
            // 
            // lblFechaNombre
            // 
            this.lblFechaNombre.AutoSize = true;
            this.lblFechaNombre.Location = new System.Drawing.Point(380, 29);
            this.lblFechaNombre.Name = "lblFechaNombre";
            this.lblFechaNombre.Size = new System.Drawing.Size(48, 16);
            this.lblFechaNombre.TabIndex = 67;
            this.lblFechaNombre.Text = "Fecha:";
            // 
            // frm_Autorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Autorizacion";
            this.Text = "TPP ERP";
            this.Load += new System.EventHandler(this.frm_Autorizacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBultos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmbalaje;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAutorizacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscarEmbalaje;
        private System.Windows.Forms.Button btnBuscarOperacion;
        private System.Windows.Forms.TextBox txtResEmbalaje;
        private System.Windows.Forms.TextBox txtResOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudPesoMaximo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudBultos;
        private System.Windows.Forms.Button btnBuscarNave;
        private System.Windows.Forms.TextBox txtNave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbFinalizado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFechaNombre;
    }
}