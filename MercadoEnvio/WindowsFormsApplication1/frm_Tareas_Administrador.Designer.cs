namespace WindowsFormsApplication1
{
    partial class frm_Tareas_Administrador
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
            this.but_Gestionar_Rol = new System.Windows.Forms.Button();
            this.but_Gestionar_Rubro = new System.Windows.Forms.Button();
            this.but_Gestionar_Usuarios = new System.Windows.Forms.Button();
            this.but_Gestionar_Visibilidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_Gestionar_Rol
            // 
            this.but_Gestionar_Rol.Location = new System.Drawing.Point(25, 25);
            this.but_Gestionar_Rol.Name = "but_Gestionar_Rol";
            this.but_Gestionar_Rol.Size = new System.Drawing.Size(121, 23);
            this.but_Gestionar_Rol.TabIndex = 0;
            this.but_Gestionar_Rol.Text = "Gestionar Rol";
            this.but_Gestionar_Rol.UseVisualStyleBackColor = true;
            // 
            // but_Gestionar_Rubro
            // 
            this.but_Gestionar_Rubro.Location = new System.Drawing.Point(25, 78);
            this.but_Gestionar_Rubro.Name = "but_Gestionar_Rubro";
            this.but_Gestionar_Rubro.Size = new System.Drawing.Size(121, 23);
            this.but_Gestionar_Rubro.TabIndex = 1;
            this.but_Gestionar_Rubro.Text = "Gestionar Rubro";
            this.but_Gestionar_Rubro.UseVisualStyleBackColor = true;
            // 
            // but_Gestionar_Usuarios
            // 
            this.but_Gestionar_Usuarios.Location = new System.Drawing.Point(25, 134);
            this.but_Gestionar_Usuarios.Name = "but_Gestionar_Usuarios";
            this.but_Gestionar_Usuarios.Size = new System.Drawing.Size(121, 23);
            this.but_Gestionar_Usuarios.TabIndex = 2;
            this.but_Gestionar_Usuarios.Text = "Gestionar Usuarios";
            this.but_Gestionar_Usuarios.UseVisualStyleBackColor = true;
            // 
            // but_Gestionar_Visibilidad
            // 
            this.but_Gestionar_Visibilidad.Location = new System.Drawing.Point(25, 182);
            this.but_Gestionar_Visibilidad.Name = "but_Gestionar_Visibilidad";
            this.but_Gestionar_Visibilidad.Size = new System.Drawing.Size(121, 23);
            this.but_Gestionar_Visibilidad.TabIndex = 3;
            this.but_Gestionar_Visibilidad.Text = "Gestionar Visibilidad";
            this.but_Gestionar_Visibilidad.UseVisualStyleBackColor = true;
            // 
            // frm_Tareas_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 249);
            this.Controls.Add(this.but_Gestionar_Visibilidad);
            this.Controls.Add(this.but_Gestionar_Usuarios);
            this.Controls.Add(this.but_Gestionar_Rubro);
            this.Controls.Add(this.but_Gestionar_Rol);
            this.Name = "frm_Tareas_Administrador";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Gestionar_Rol;
        private System.Windows.Forms.Button but_Gestionar_Rubro;
        private System.Windows.Forms.Button but_Gestionar_Usuarios;
        private System.Windows.Forms.Button but_Gestionar_Visibilidad;
    }
}