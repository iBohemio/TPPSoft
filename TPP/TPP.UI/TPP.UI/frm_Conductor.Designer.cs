namespace TPP.UI
{
    partial class frm_Conductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Conductor));
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrevete = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "A. Materno:";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(160, 155);
            this.txtAPaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(177, 22);
            this.txtAPaterno.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(160, 123);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(177, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "A. Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombres:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblConductor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 60);
            this.panel1.TabIndex = 27;
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
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.ForeColor = System.Drawing.Color.White;
            this.lblConductor.Location = new System.Drawing.Point(51, 25);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(73, 16);
            this.lblConductor.TabIndex = 1;
            this.lblConductor.Text = "Conductor";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(218, 233);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 37);
            this.btnSalir.TabIndex = 5;
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
            this.btnRegistrar.Location = new System.Drawing.Point(28, 233);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 37);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(160, 187);
            this.txtAMaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(177, 22);
            this.txtAMaterno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nro. Brevete:";
            // 
            // txtBrevete
            // 
            this.txtBrevete.Location = new System.Drawing.Point(160, 91);
            this.txtBrevete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrevete.Name = "txtBrevete";
            this.txtBrevete.Size = new System.Drawing.Size(177, 22);
            this.txtBrevete.TabIndex = 0;
            // 
            // frm_Conductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 283);
            this.Controls.Add(this.txtBrevete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Conductor";
            this.Text = "TPP ERP";
            this.Load += new System.EventHandler(this.frm_Conductor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrevete;
    }
}