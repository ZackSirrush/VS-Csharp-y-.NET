namespace DPRN3_U3_ANNT
{
    partial class RegVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plantacb = new System.Windows.Forms.ComboBox();
            this.fvtadtp = new System.Windows.Forms.DateTimePicker();
            this.cantidadtb = new System.Windows.Forms.TextBox();
            this.totaltb = new System.Windows.Forms.TextBox();
            this.validarbttn = new System.Windows.Forms.Button();
            this.registrarbttn = new System.Windows.Forms.Button();
            this.actualizarbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registar venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(73, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(73, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(73, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // plantacb
            // 
            this.plantacb.CausesValidation = false;
            this.plantacb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantacb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plantacb.FormattingEnabled = true;
            this.plantacb.Items.AddRange(new object[] {
            "Agave",
            "Biznaga",
            "Cempasuchil",
            "Dalia",
            "Magnolia Pacifica",
            "Nochebuena",
            "Nopal Cardon",
            "Orquidea Pelicano",
            "Peyote",
            "Peyotillo",
            "Zapatilla de Venus"});
            this.plantacb.Location = new System.Drawing.Point(211, 93);
            this.plantacb.MaxLength = 30;
            this.plantacb.Name = "plantacb";
            this.plantacb.Size = new System.Drawing.Size(178, 21);
            this.plantacb.Sorted = true;
            this.plantacb.TabIndex = 5;
            this.plantacb.TextChanged += new System.EventHandler(this.plantacb_TextChanged);
            // 
            // fvtadtp
            // 
            this.fvtadtp.CustomFormat = "yyy-MM-01";
            this.fvtadtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fvtadtp.Location = new System.Drawing.Point(211, 120);
            this.fvtadtp.Name = "fvtadtp";
            this.fvtadtp.Size = new System.Drawing.Size(93, 20);
            this.fvtadtp.TabIndex = 6;
            this.fvtadtp.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // cantidadtb
            // 
            this.cantidadtb.Location = new System.Drawing.Point(211, 146);
            this.cantidadtb.Name = "cantidadtb";
            this.cantidadtb.Size = new System.Drawing.Size(178, 20);
            this.cantidadtb.TabIndex = 7;
            this.cantidadtb.Text = "0";
            this.cantidadtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantidadtb.TextChanged += new System.EventHandler(this.cantidadtb_TextChanged);
            this.cantidadtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadtb_KeyPress);
            // 
            // totaltb
            // 
            this.totaltb.Enabled = false;
            this.totaltb.Location = new System.Drawing.Point(211, 172);
            this.totaltb.Name = "totaltb";
            this.totaltb.Size = new System.Drawing.Size(178, 20);
            this.totaltb.TabIndex = 8;
            this.totaltb.Text = "0";
            this.totaltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totaltb.TextChanged += new System.EventHandler(this.totaltb_TextChanged);
            // 
            // validarbttn
            // 
            this.validarbttn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarbttn.Location = new System.Drawing.Point(310, 120);
            this.validarbttn.Name = "validarbttn";
            this.validarbttn.Size = new System.Drawing.Size(79, 20);
            this.validarbttn.TabIndex = 9;
            this.validarbttn.Text = "Validar";
            this.validarbttn.UseVisualStyleBackColor = true;
            this.validarbttn.Click += new System.EventHandler(this.validarbttn_Click);
            // 
            // registrarbttn
            // 
            this.registrarbttn.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarbttn.Location = new System.Drawing.Point(245, 267);
            this.registrarbttn.Name = "registrarbttn";
            this.registrarbttn.Size = new System.Drawing.Size(189, 93);
            this.registrarbttn.TabIndex = 10;
            this.registrarbttn.Text = "Nuevo registro";
            this.registrarbttn.UseVisualStyleBackColor = true;
            this.registrarbttn.Click += new System.EventHandler(this.registrarbttn_Click);
            // 
            // actualizarbttn
            // 
            this.actualizarbttn.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarbttn.Location = new System.Drawing.Point(16, 267);
            this.actualizarbttn.Name = "actualizarbttn";
            this.actualizarbttn.Size = new System.Drawing.Size(189, 93);
            this.actualizarbttn.TabIndex = 11;
            this.actualizarbttn.Text = "Actualizar";
            this.actualizarbttn.UseVisualStyleBackColor = true;
            this.actualizarbttn.Click += new System.EventHandler(this.actualizarbttn_Click);
            // 
            // RegVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(459, 451);
            this.Controls.Add(this.actualizarbttn);
            this.Controls.Add(this.registrarbttn);
            this.Controls.Add(this.validarbttn);
            this.Controls.Add(this.totaltb);
            this.Controls.Add(this.cantidadtb);
            this.Controls.Add(this.fvtadtp);
            this.Controls.Add(this.plantacb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nueva venta";
            this.Load += new System.EventHandler(this.RegVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox plantacb;
        private System.Windows.Forms.DateTimePicker fvtadtp;
        private System.Windows.Forms.TextBox cantidadtb;
        private System.Windows.Forms.TextBox totaltb;
        private System.Windows.Forms.Button validarbttn;
        private System.Windows.Forms.Button registrarbttn;
        private System.Windows.Forms.Button actualizarbttn;
    }
}