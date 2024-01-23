namespace DPRN3_U3_ANNT
{
    partial class VtaMensual
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtaMensual));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvbdremota = new System.Windows.Forms.DataGridView();
            this.Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbdlocal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plantartb = new System.Windows.Forms.TextBox();
            this.fechartb = new System.Windows.Forms.TextBox();
            this.cantidadrtb = new System.Windows.Forms.TextBox();
            this.totalrtb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buscartb = new System.Windows.Forms.TextBox();
            this.buscarbttn = new System.Windows.Forms.Button();
            this.totalltb = new System.Windows.Forms.TextBox();
            this.cantidadltb = new System.Windows.Forms.TextBox();
            this.fechaltb = new System.Windows.Forms.TextBox();
            this.plantaltb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reestablecerbttn = new System.Windows.Forms.Button();
            this.actualizarbttn = new System.Windows.Forms.Button();
            this.eliminarbttn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbdremota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbdlocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 735);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(178, 17);
            this.toolStripStatusLabel1.Text = "Cantidad de registros remotos: 0";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(170, 17);
            this.toolStripStatusLabel2.Text = "Cantidad de registros locales: 0";
            // 
            // dgvbdremota
            // 
            this.dgvbdremota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbdremota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Planta,
            this.Fecha,
            this.Cantidad,
            this.Total});
            this.dgvbdremota.Location = new System.Drawing.Point(12, 245);
            this.dgvbdremota.Name = "dgvbdremota";
            this.dgvbdremota.Size = new System.Drawing.Size(443, 487);
            this.dgvbdremota.TabIndex = 1;
            this.dgvbdremota.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // Planta
            // 
            this.Planta.HeaderText = "Planta";
            this.Planta.Name = "Planta";
            this.Planta.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dgvbdlocal
            // 
            this.dgvbdlocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbdlocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvbdlocal.Location = new System.Drawing.Point(517, 245);
            this.dgvbdlocal.Name = "dgvbdlocal";
            this.dgvbdlocal.Size = new System.Drawing.Size(443, 487);
            this.dgvbdlocal.TabIndex = 2;
            this.dgvbdlocal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbdlocal_CellContentClick);
            this.dgvbdlocal.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectLocal);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Planta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base de datos remota ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(573, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base de datos local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(53, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Planta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(53, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(53, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(53, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantidad";
            // 
            // plantartb
            // 
            this.plantartb.Enabled = false;
            this.plantartb.Location = new System.Drawing.Point(148, 82);
            this.plantartb.Name = "plantartb";
            this.plantartb.Size = new System.Drawing.Size(100, 20);
            this.plantartb.TabIndex = 13;
            // 
            // fechartb
            // 
            this.fechartb.Enabled = false;
            this.fechartb.Location = new System.Drawing.Point(148, 105);
            this.fechartb.Name = "fechartb";
            this.fechartb.Size = new System.Drawing.Size(100, 20);
            this.fechartb.TabIndex = 14;
            // 
            // cantidadrtb
            // 
            this.cantidadrtb.Enabled = false;
            this.cantidadrtb.Location = new System.Drawing.Point(148, 128);
            this.cantidadrtb.Name = "cantidadrtb";
            this.cantidadrtb.Size = new System.Drawing.Size(100, 20);
            this.cantidadrtb.TabIndex = 15;
            // 
            // totalrtb
            // 
            this.totalrtb.Enabled = false;
            this.totalrtb.Location = new System.Drawing.Point(148, 151);
            this.totalrtb.Name = "totalrtb";
            this.totalrtb.Size = new System.Drawing.Size(100, 20);
            this.totalrtb.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(524, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Buscar";
            // 
            // buscartb
            // 
            this.buscartb.Location = new System.Drawing.Point(585, 214);
            this.buscartb.Name = "buscartb";
            this.buscartb.Size = new System.Drawing.Size(117, 20);
            this.buscartb.TabIndex = 22;
            // 
            // buscarbttn
            // 
            this.buscarbttn.Location = new System.Drawing.Point(708, 213);
            this.buscarbttn.Name = "buscarbttn";
            this.buscarbttn.Size = new System.Drawing.Size(52, 21);
            this.buscarbttn.TabIndex = 25;
            this.buscarbttn.Text = "Buscar";
            this.buscarbttn.UseVisualStyleBackColor = true;
            this.buscarbttn.Click += new System.EventHandler(this.buscarbttn_Click);
            // 
            // totalltb
            // 
            this.totalltb.Enabled = false;
            this.totalltb.Location = new System.Drawing.Point(657, 147);
            this.totalltb.Name = "totalltb";
            this.totalltb.Size = new System.Drawing.Size(100, 20);
            this.totalltb.TabIndex = 34;
            // 
            // cantidadltb
            // 
            this.cantidadltb.Location = new System.Drawing.Point(657, 124);
            this.cantidadltb.Name = "cantidadltb";
            this.cantidadltb.Size = new System.Drawing.Size(100, 20);
            this.cantidadltb.TabIndex = 33;
            this.cantidadltb.TextChanged += new System.EventHandler(this.cantidadltb_TextChanged);
            this.cantidadltb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadltb_KeyPress);
            // 
            // fechaltb
            // 
            this.fechaltb.Enabled = false;
            this.fechaltb.Location = new System.Drawing.Point(657, 101);
            this.fechaltb.Name = "fechaltb";
            this.fechaltb.Size = new System.Drawing.Size(100, 20);
            this.fechaltb.TabIndex = 32;
            // 
            // plantaltb
            // 
            this.plantaltb.Enabled = false;
            this.plantaltb.Location = new System.Drawing.Point(657, 78);
            this.plantaltb.Name = "plantaltb";
            this.plantaltb.Size = new System.Drawing.Size(100, 20);
            this.plantaltb.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(562, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(562, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(562, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(562, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Planta";
            // 
            // reestablecerbttn
            // 
            this.reestablecerbttn.Location = new System.Drawing.Point(766, 213);
            this.reestablecerbttn.Name = "reestablecerbttn";
            this.reestablecerbttn.Size = new System.Drawing.Size(82, 21);
            this.reestablecerbttn.TabIndex = 35;
            this.reestablecerbttn.Text = "Reestablecer";
            this.reestablecerbttn.UseVisualStyleBackColor = true;
            this.reestablecerbttn.Click += new System.EventHandler(this.reestablecerbttn_Click);
            // 
            // actualizarbttn
            // 
            this.actualizarbttn.Location = new System.Drawing.Point(795, 76);
            this.actualizarbttn.Name = "actualizarbttn";
            this.actualizarbttn.Size = new System.Drawing.Size(121, 47);
            this.actualizarbttn.TabIndex = 36;
            this.actualizarbttn.Text = "Actualizar";
            this.actualizarbttn.UseVisualStyleBackColor = true;
            this.actualizarbttn.Click += new System.EventHandler(this.actualizarbttn_Click);
            // 
            // eliminarbttn
            // 
            this.eliminarbttn.Location = new System.Drawing.Point(795, 128);
            this.eliminarbttn.Name = "eliminarbttn";
            this.eliminarbttn.Size = new System.Drawing.Size(121, 47);
            this.eliminarbttn.TabIndex = 37;
            this.eliminarbttn.Text = "Eliminar";
            this.eliminarbttn.UseVisualStyleBackColor = true;
            this.eliminarbttn.Click += new System.EventHandler(this.eliminarbttn_Click);
            // 
            // VtaMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 757);
            this.Controls.Add(this.eliminarbttn);
            this.Controls.Add(this.actualizarbttn);
            this.Controls.Add(this.reestablecerbttn);
            this.Controls.Add(this.totalltb);
            this.Controls.Add(this.cantidadltb);
            this.Controls.Add(this.fechaltb);
            this.Controls.Add(this.plantaltb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buscarbttn);
            this.Controls.Add(this.buscartb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalrtb);
            this.Controls.Add(this.cantidadrtb);
            this.Controls.Add(this.fechartb);
            this.Controls.Add(this.plantartb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvbdlocal);
            this.Controls.Add(this.dgvbdremota);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VtaMensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Mensuales";
            this.Load += new System.EventHandler(this.VtaMensual_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbdremota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbdlocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvbdremota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView dgvbdlocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox plantartb;
        private System.Windows.Forms.TextBox fechartb;
        private System.Windows.Forms.TextBox cantidadrtb;
        private System.Windows.Forms.TextBox totalrtb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox buscartb;
        private System.Windows.Forms.Button buscarbttn;
        private System.Windows.Forms.TextBox totalltb;
        private System.Windows.Forms.TextBox cantidadltb;
        private System.Windows.Forms.TextBox fechaltb;
        private System.Windows.Forms.TextBox plantaltb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Button reestablecerbttn;
        private System.Windows.Forms.Button actualizarbttn;
        private System.Windows.Forms.Button eliminarbttn;
    }
}