namespace WindowsFormsApplication1.ABM_Rol
{
    partial class frm_Elije_rol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Continuar = new System.Windows.Forms.Button();
            this.dgw_Total_de_roles_disponibles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Total_de_roles_disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_Total_de_roles_disponibles);
            this.groupBox1.Controls.Add(this.but_Continuar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un rol";
            // 
            // but_Continuar
            // 
            this.but_Continuar.Location = new System.Drawing.Point(30, 136);
            this.but_Continuar.Name = "but_Continuar";
            this.but_Continuar.Size = new System.Drawing.Size(133, 37);
            this.but_Continuar.TabIndex = 2;
            this.but_Continuar.Text = "Continuar";
            this.but_Continuar.UseVisualStyleBackColor = true;
            // 
            // dgw_Total_de_roles_disponibles
            // 
            this.dgw_Total_de_roles_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Total_de_roles_disponibles.Location = new System.Drawing.Point(30, 27);
            this.dgw_Total_de_roles_disponibles.Name = "dgw_Total_de_roles_disponibles";
            this.dgw_Total_de_roles_disponibles.Size = new System.Drawing.Size(132, 85);
            this.dgw_Total_de_roles_disponibles.TabIndex = 3;
            // 
            // frm_Elije_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Elije_rol";
            this.Text = "Selecciona rol";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Total_de_roles_disponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_Continuar;
        private System.Windows.Forms.DataGridView dgw_Total_de_roles_disponibles;
    }
}