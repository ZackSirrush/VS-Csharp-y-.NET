namespace DPRN3_U3_ANNT
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.vmbttn = new System.Windows.Forms.Button();
            this.vtbttn = new System.Windows.Forms.Button();
            this.ventabttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vmbttn
            // 
            this.vmbttn.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmbttn.Location = new System.Drawing.Point(55, 181);
            this.vmbttn.Name = "vmbttn";
            this.vmbttn.Size = new System.Drawing.Size(306, 96);
            this.vmbttn.TabIndex = 0;
            this.vmbttn.Text = "Resumen de ventas mensuales";
            this.vmbttn.UseVisualStyleBackColor = true;
            this.vmbttn.Click += new System.EventHandler(this.vmbttn_Click);
            // 
            // vtbttn
            // 
            this.vtbttn.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtbttn.Location = new System.Drawing.Point(55, 47);
            this.vtbttn.Name = "vtbttn";
            this.vtbttn.Size = new System.Drawing.Size(306, 96);
            this.vtbttn.TabIndex = 1;
            this.vtbttn.Text = "Resumen de ventas totales";
            this.vtbttn.UseVisualStyleBackColor = true;
            this.vtbttn.Click += new System.EventHandler(this.vtbttn_Click);
            // 
            // ventabttn
            // 
            this.ventabttn.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventabttn.Location = new System.Drawing.Point(55, 319);
            this.ventabttn.Name = "ventabttn";
            this.ventabttn.Size = new System.Drawing.Size(306, 96);
            this.ventabttn.TabIndex = 2;
            this.ventabttn.Text = "Registrar venta";
            this.ventabttn.UseVisualStyleBackColor = true;
            this.ventabttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(412, 451);
            this.Controls.Add(this.ventabttn);
            this.Controls.Add(this.vtbttn);
            this.Controls.Add(this.vmbttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vmbttn;
        private System.Windows.Forms.Button vtbttn;
        private System.Windows.Forms.Button ventabttn;
    }
}