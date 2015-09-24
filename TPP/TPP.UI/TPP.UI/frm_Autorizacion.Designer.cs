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
            this.ndPesoMaximo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ndBultos = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.txtNave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbFinalizado = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndPesoMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndBultos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(143, 110);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(220, 22);
            this.txtCodigo.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Código:";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(143, 206);
            this.txtOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(118, 22);
            this.txtOperacion.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Operación:";
            // 
            // txtEmbalaje
            // 
            this.txtEmbalaje.Location = new System.Drawing.Point(143, 174);
            this.txtEmbalaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmbalaje.Name = "txtEmbalaje";
            this.txtEmbalaje.Size = new System.Drawing.Size(118, 22);
            this.txtEmbalaje.TabIndex = 42;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(143, 142);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(220, 22);
            this.txtProducto.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Embalaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 146);
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
            this.panel1.Size = new System.Drawing.Size(693, 60);
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
            this.btnSalir.Location = new System.Drawing.Point(401, 370);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 37);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(218, 370);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 37);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(140, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblUsuario.TabIndex = 48;
            this.lblUsuario.Text = "[Usuario]";
            // 
            // btnBuscarEmbalaje
            // 
            this.btnBuscarEmbalaje.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmbalaje.Image")));
            this.btnBuscarEmbalaje.Location = new System.Drawing.Point(267, 173);
            this.btnBuscarEmbalaje.Name = "btnBuscarEmbalaje";
            this.btnBuscarEmbalaje.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarEmbalaje.TabIndex = 49;
            this.btnBuscarEmbalaje.UseVisualStyleBackColor = true;
            // 
            // btnBuscarOperacion
            // 
            this.btnBuscarOperacion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOperacion.Image")));
            this.btnBuscarOperacion.Location = new System.Drawing.Point(267, 205);
            this.btnBuscarOperacion.Name = "btnBuscarOperacion";
            this.btnBuscarOperacion.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarOperacion.TabIndex = 50;
            this.btnBuscarOperacion.UseVisualStyleBackColor = true;
            // 
            // txtResEmbalaje
            // 
            this.txtResEmbalaje.Location = new System.Drawing.Point(299, 174);
            this.txtResEmbalaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResEmbalaje.Name = "txtResEmbalaje";
            this.txtResEmbalaje.ReadOnly = true;
            this.txtResEmbalaje.Size = new System.Drawing.Size(352, 22);
            this.txtResEmbalaje.TabIndex = 51;
            // 
            // txtResOperacion
            // 
            this.txtResOperacion.Location = new System.Drawing.Point(299, 206);
            this.txtResOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResOperacion.Name = "txtResOperacion";
            this.txtResOperacion.ReadOnly = true;
            this.txtResOperacion.Size = new System.Drawing.Size(352, 22);
            this.txtResOperacion.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Bultos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kg.";
            // 
            // ndPesoMaximo
            // 
            this.ndPesoMaximo.Location = new System.Drawing.Point(143, 269);
            this.ndPesoMaximo.Name = "ndPesoMaximo";
            this.ndPesoMaximo.Size = new System.Drawing.Size(152, 22);
            this.ndPesoMaximo.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Peso Máximo:";
            // 
            // ndBultos
            // 
            this.ndBultos.Location = new System.Drawing.Point(143, 241);
            this.ndBultos.Name = "ndBultos";
            this.ndBultos.Size = new System.Drawing.Size(152, 22);
            this.ndBultos.TabIndex = 57;
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNave.Image")));
            this.btnBuscarNave.Location = new System.Drawing.Point(268, 301);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarNave.TabIndex = 60;
            this.btnBuscarNave.UseVisualStyleBackColor = true;
            // 
            // txtNave
            // 
            this.txtNave.Location = new System.Drawing.Point(144, 302);
            this.txtNave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNave.Name = "txtNave";
            this.txtNave.Size = new System.Drawing.Size(118, 22);
            this.txtNave.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Nave:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(144, 335);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Estado:";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(375, 304);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(61, 20);
            this.rdbActivo.TabIndex = 64;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbFinalizado
            // 
            this.rdbFinalizado.AutoSize = true;
            this.rdbFinalizado.Location = new System.Drawing.Point(480, 306);
            this.rdbFinalizado.Name = "rdbFinalizado";
            this.rdbFinalizado.Size = new System.Drawing.Size(85, 20);
            this.rdbFinalizado.TabIndex = 65;
            this.rdbFinalizado.TabStop = true;
            this.rdbFinalizado.Text = "Finalizado";
            this.rdbFinalizado.UseVisualStyleBackColor = true;
            // 
            // frm_Autorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 420);
            this.Controls.Add(this.rdbFinalizado);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscarNave);
            this.Controls.Add(this.txtNave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ndBultos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ndPesoMaximo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResOperacion);
            this.Controls.Add(this.txtResEmbalaje);
            this.Controls.Add(this.btnBuscarOperacion);
            this.Controls.Add(this.btnBuscarEmbalaje);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmbalaje);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Autorizacion";
            this.Text = "TPP ERP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndPesoMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndBultos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown ndPesoMaximo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ndBultos;
        private System.Windows.Forms.Button btnBuscarNave;
        private System.Windows.Forms.TextBox txtNave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbFinalizado;
    }
}