namespace WindowsFormsApplication1.ABM_Rol
{
    partial class frm_Gestion_Rol_Guardar
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
            this.but_Guardar = new System.Windows.Forms.Button();
            this.lab_Nombre_Rol = new System.Windows.Forms.Label();
            this.lab_Funcionalidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but_Guardar
            // 
            this.but_Guardar.Location = new System.Drawing.Point(81, 112);
            this.but_Guardar.Name = "but_Guardar";
            this.but_Guardar.Size = new System.Drawing.Size(75, 23);
            this.but_Guardar.TabIndex = 0;
            this.but_Guardar.Text = "Guardar";
            this.but_Guardar.UseVisualStyleBackColor = true;
            // 
            // lab_Nombre_Rol
            // 
            this.lab_Nombre_Rol.AutoSize = true;
            this.lab_Nombre_Rol.Location = new System.Drawing.Point(31, 30);
            this.lab_Nombre_Rol.Name = "lab_Nombre_Rol";
            this.lab_Nombre_Rol.Size = new System.Drawing.Size(73, 13);
            this.lab_Nombre_Rol.TabIndex = 2;
            this.lab_Nombre_Rol.Text = "Nombre de rol";
            this.lab_Nombre_Rol.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_Funcionalidad
            // 
            this.lab_Funcionalidad.AutoSize = true;
            this.lab_Funcionalidad.Location = new System.Drawing.Point(31, 69);
            this.lab_Funcionalidad.Name = "lab_Funcionalidad";
            this.lab_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.lab_Funcionalidad.TabIndex = 3;
            this.lab_Funcionalidad.Text = "Funcionalidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // frm_Gestion_Rol_Guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 151);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_Funcionalidad);
            this.Controls.Add(this.lab_Nombre_Rol);
            this.Controls.Add(this.but_Guardar);
            this.Name = "frm_Gestion_Rol_Guardar";
            this.Text = "Guardar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Guardar;
        private System.Windows.Forms.Label lab_Nombre_Rol;
        private System.Windows.Forms.Label lab_Funcionalidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}