namespace DPRN3_U2_A1_ANNT
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
            this.RVbttn = new System.Windows.Forms.Button();
            this.RUbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RVbttn
            // 
            this.RVbttn.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RVbttn.Image = ((System.Drawing.Image)(resources.GetObject("RVbttn.Image")));
            this.RVbttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RVbttn.Location = new System.Drawing.Point(12, 38);
            this.RVbttn.Name = "RVbttn";
            this.RVbttn.Size = new System.Drawing.Size(139, 110);
            this.RVbttn.TabIndex = 0;
            this.RVbttn.Text = "Registrar vehiculo";
            this.RVbttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RVbttn.UseVisualStyleBackColor = true;
            this.RVbttn.Click += new System.EventHandler(this.RVbttn_Click);
            // 
            // RUbttn
            // 
            this.RUbttn.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RUbttn.Image = ((System.Drawing.Image)(resources.GetObject("RUbttn.Image")));
            this.RUbttn.Location = new System.Drawing.Point(192, 38);
            this.RUbttn.Name = "RUbttn";
            this.RUbttn.Size = new System.Drawing.Size(139, 110);
            this.RUbttn.TabIndex = 1;
            this.RUbttn.Text = "Registrar usuario";
            this.RUbttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RUbttn.UseVisualStyleBackColor = true;
            this.RUbttn.Click += new System.EventHandler(this.RUbttn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(343, 185);
            this.Controls.Add(this.RUbttn);
            this.Controls.Add(this.RVbttn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RVbttn;
        private Button RUbttn;
    }
}