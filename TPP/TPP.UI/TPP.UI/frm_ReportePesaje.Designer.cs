namespace TPP.UI
{
    partial class frm_ReportePesaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportePesaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContenedor = new System.Windows.Forms.Label();
            this.crvPesaje = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crPesaje1 = new TPP.UI.crPesaje();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblContenedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 60);
            this.panel1.TabIndex = 134;
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
            // lblContenedor
            // 
            this.lblContenedor.AutoSize = true;
            this.lblContenedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenedor.ForeColor = System.Drawing.Color.White;
            this.lblContenedor.Location = new System.Drawing.Point(51, 25);
            this.lblContenedor.Name = "lblContenedor";
            this.lblContenedor.Size = new System.Drawing.Size(125, 16);
            this.lblContenedor.TabIndex = 1;
            this.lblContenedor.Text = "Reporte de Pesaje";
            // 
            // crvPesaje
            // 
            this.crvPesaje.ActiveViewIndex = 0;
            this.crvPesaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPesaje.CachedPageNumberPerDoc = 10;
            this.crvPesaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPesaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPesaje.Location = new System.Drawing.Point(0, 60);
            this.crvPesaje.Name = "crvPesaje";
            this.crvPesaje.ReportSource = this.crPesaje1;
            this.crvPesaje.ShowGroupTreeButton = false;
            this.crvPesaje.Size = new System.Drawing.Size(1064, 625);
            this.crvPesaje.TabIndex = 135;
            this.crvPesaje.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_ReportePesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 685);
            this.Controls.Add(this.crvPesaje);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ReportePesaje";
            this.Text = "TPP ERP";
            this.Load += new System.EventHandler(this.frm_ReportePesaje_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContenedor;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPesaje;
        private crPesaje crPesaje1;
    }
}